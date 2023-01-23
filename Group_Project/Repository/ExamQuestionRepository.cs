using Group_Project.Data;
using Group_Project.Repository.IRepository;
using Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Repository
{
    public class ExamQuestionRepository:  Repository<ExamQuestion>, IExamQuestionRepository
    {
        private readonly MyDbContext _context;

        public ExamQuestionRepository(MyDbContext context) : base(context) 
        {
            _context= context;
        }

        public void Update(ExamQuestion examQuestion)
        {
            _context.Update(examQuestion);
        }

        public async Task<IEnumerable<ExamQuestion>> GetAllExamQuestionsAs()
        {
            return await _context.Set<ExamQuestion>().Include(x => x.ExamTopics).Include(x=>x.QuestionAnswer).ToListAsync();
        }
    }
}
