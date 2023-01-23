using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
    public interface ICandidateRepository : IRepository<Candidate>
    {
        void Update(Candidate candidate);
    }
}
