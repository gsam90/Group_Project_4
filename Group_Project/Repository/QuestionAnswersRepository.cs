 using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Repository
{
    public class QuestionAnswersRepository : Repository<QuestionAnswers> , IQuestionAnswersRepository
    {
        private readonly MyDbContext _context;
        public QuestionAnswersRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(QuestionAnswers questionAnswers)
        {
            _context.Update(questionAnswers);
        }

        public async Task<IEnumerable<QuestionAnswers>> GetAllQuestionAnswersAs()
        {
            return await _context.Set<QuestionAnswers>().Include(x => x.Topics.Certificate).ToListAsync();
        }

    }
}
