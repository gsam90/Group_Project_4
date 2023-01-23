using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;

namespace Group_Project.Repository
{
    public class CertificateRepository : Repository<Certificate>, ICertificateRepository
    {
        private readonly MyDbContext _context;

        public CertificateRepository (MyDbContext context) : base (context)
        {
            _context = context;
        }

        public void Update(Certificate certificate)

        {
            _context.Update(certificate);
        }
    }
}
