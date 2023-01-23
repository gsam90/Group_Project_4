using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Group_Project.Controllers
{
    public class ExamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Exam()
        {
            var candidate1 = _unitOfWork.Candidate.Get(1);
            var certificate1 = _unitOfWork.Certificate.Get(1);
            var topic1 = _unitOfWork.Topic.Get(1);
            var allQuestionAnswers = await _unitOfWork.QuestionAnswers.GetAllQuestionAnswersAs();

            var exam = new Exam() { Certificate = certificate1, ExamDuration = DateTime.Now.AddHours(3) };
            
            
            foreach (var questionAnswer in allQuestionAnswers)
            {
                var examTopics1 = new ExamTopics
                {
                    Topic = topic1,
                    Exam = exam
                };
                var examQuestion1 = new ExamQuestion
                {
                    ExamTopics = examTopics1,
                    QuestionAnswer = questionAnswer
                };

                var candidateExamination = new CandidateExamination
                {
                    Exam = exam,
                    Candidate = candidate1,
                    CandidateQuestionAnswer = -1,
                    ExamQuestion = examQuestion1,
                    QuestionResult = -1,
                    ExamStartingTime = DateTime.UtcNow,
                    timestamp = DateTime.UtcNow,

                };

                _unitOfWork.CandidateExamination.Add(candidateExamination);
                _unitOfWork.Save();
            }
            var listOfCandidateExamination = await _unitOfWork.CandidateExamination.GetAllCandidateExaminationsAs();
            // Get candidate
            // Get Certificate
            // Get Topic
            // Get questions from pool of quiestions
            // Get duration
            // Get Timestamp??
            // foreach question in getQUestions
            // add Question to CandidateExamination
            // 
            // GetList CandidateExamination
            // Send List To View

            //var ListOfQuestions = await _unitOfWork.Question.GetAllLoadedAs();

            return View(listOfCandidateExamination);
        }
        [HttpPost]
        public IActionResult Exam(string id)
        {
            string[] value = id.Split(',');
            int answer = Int32.Parse(value[0]);
            int CandidateExaminationId = Int32.Parse(value[1]);
            _unitOfWork.CandidateExamination.UpdateCandidateQuestionAnswer(CandidateExaminationId, answer);
            _unitOfWork.Save();
            return RedirectToPage("Exam");
        }

        [HttpPost]
        public IActionResult UpdateQuestionAnswer(CandidateExamination candidateExamination)
        {

            return View();
        }
    }
}