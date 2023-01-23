using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Repository
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        private readonly MyDbContext _context;

        public QuestionRepository(MyDbContext context) : base (context)
        {
            _context = context;
        }

		public async Task<IEnumerable<Question>> GetAllLoadedAs()
		{
            return await _context.Set<Question>().Include(x => x.PossibleAnswers).Include(x => x.Topics.Certificate).ToListAsync();
		}

		public async Task<Question> GetLoadedAs(int id)
		{
			return await _context.Set<Question>().Include(x => x.PossibleAnswers).Include(x => x.Topics.Certificate.Topics).Where(x => x.Id == id).SingleAsync();
		}

		public void Update(Question question)
        {
            _context.Update(question);
        }
    }
}
