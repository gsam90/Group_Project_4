using Group_Project.Data;

using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Repository
{
    public class CandidateExaminationRepository : Repository<CandidateExamination>, ICandidateExaminationRepository
    {
        private readonly MyDbContext _context;

        public CandidateExaminationRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(CandidateExamination candidateExamination)
        {
            _context.Update(candidateExamination);
        }

        public async Task<IEnumerable<CandidateExamination>> GetAllCandidateExaminationsAs()
        {
            return await _context.Set<CandidateExamination>().Include(x => x.Candidate).Include(x => x.Exam).Include(x => x.ExamQuestion).ToListAsync();
        }

        public void UpdateCandidateQuestionAnswer(int? candidateExaminationId, int? answer)
        {
            var candidateExamination = _context.Set<CandidateExamination>().FirstOrDefault(c => c.Id == candidateExaminationId);
            candidateExamination.CandidateQuestionAnswer = answer;

        }
    }
}
