using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
    public interface IExamQuestionRepository: IRepository<ExamQuestion>
    {
        void Update(ExamQuestion examQuestion);

        Task<IEnumerable<ExamQuestion>> GetAllExamQuestionsAs();
    }
}
