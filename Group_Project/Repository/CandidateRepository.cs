using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;

namespace Group_Project.Repository
{
    public class CandidateRepository : Repository<Candidate>, ICandidateRepository
    {
        private readonly MyDbContext _context;
        public CandidateRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Candidate candidate)
        {
            _context.Update(candidate);
        }

    }
}
