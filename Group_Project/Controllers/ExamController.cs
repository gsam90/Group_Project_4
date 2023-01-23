using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Examzzz()
        {
            var candidate1 = _unitOfWork.Candidate.Get(1);
            var certificate1 = _unitOfWork.Certificate.Get(1);
            var topic1 = _unitOfWork.Topic.Get(1);
            var allQuestionAnswers = await _unitOfWork.ExamQuestion.GetAllQuestionAnswersAs();
            foreach (var questionAnswer in allQuestionAnswers)
            {
                var exam = new Exam() { Certificate = certificate1, ExamDuration = DateTime.Now.AddHours(3) };

                var candidateExamination = new CandidateExamination
                {
                    Exam = exam,
                    //Exam.Certificate = certificate1,
                    Candidate = candidate1,
                    //Certificate = certificate1,
                    //Topic = topic1,
                    //QuestionAnswers = questionAnswer,
                    CandidateQuestionAnswer = -1,
                    QuestionResult = -1,
                    ExamStartingTime = DateTime.UtcNow,
                    timestamp = DateTime.UtcNow,
                    //ExamDuration = DateTime.Now.AddHours(3)

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
        public IActionResult Examzz(string id)
        {
            string[] value = id.Split(',');
            int answer = Int32.Parse(value[0]);
            int CandidateExaminationId = Int32.Parse(value[1]);
            _unitOfWork.CandidateExamination.UpdateCandidateQuestionAnswer(CandidateExaminationId, answer);
            _unitOfWork.Save();
            return View();
        }

        [HttpPost]
        public IActionResult UpdateQuestionAnswer(CandidateExamination candidateExamination)
        {

            return View();
        }
    }
}