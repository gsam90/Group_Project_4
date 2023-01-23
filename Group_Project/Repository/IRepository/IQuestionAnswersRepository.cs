using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
    public interface IQuestionAnswersRepository : IRepository<QuestionAnswers>
    {
        void Update(QuestionAnswers questionAnswers);

        Task<IEnumerable<QuestionAnswers>> GetAllQuestionAnswersAs();

    }
}
