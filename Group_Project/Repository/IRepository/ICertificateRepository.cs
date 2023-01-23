using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
    public interface ICertificateRepository : IRepository<Certificate>
    {
        void Update(Certificate certificate);
    }
}
