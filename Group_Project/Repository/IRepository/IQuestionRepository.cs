using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
    public interface IQuestionRepository : IRepository<Question>
    {
        void Update(Question question);
        Task<IEnumerable<Question>> GetAllLoadedAs();
        Task<Question> GetLoadedAs(int id);
    }
}
