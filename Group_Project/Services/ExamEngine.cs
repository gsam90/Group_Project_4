using Group_Project.Models;
using Group_Project.Repository.IRepository;

namespace Group_Project.Services
{
    public class ExamEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int ExamEngineResult (ExamQuestions examQuestions)
        {
            return 0;
        }
    }
}
