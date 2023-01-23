using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;

namespace Group_Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private MyDbContext _context;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
            Candidate = new CandidateRepository(_context);
            Certificate = new CertificateRepository(_context);
            Topic = new TopicRepository(_context);
            QuestionAnswers = new QuestionAnswersRepository(_context);
            CandidateExamination =  new CandidateExaminationRepository(_context);
            ExamQuestion = new ExamQuestionRepository(_context);
        }

        public ICandidateRepository Candidate { get; private set; }


        public ICertificateRepository Certificate { get; private set; }

		public ITopicRepository Topic { get ; private set; }


        public ICandidateExaminationRepository CandidateExamination { get; private set; }
        public IQuestionAnswersRepository QuestionAnswers { get; private set; }

        public IExamQuestionRepository ExamQuestion { get; private set; }

        public void Save()
        { 
            _context.SaveChanges();
        }
    }
}
