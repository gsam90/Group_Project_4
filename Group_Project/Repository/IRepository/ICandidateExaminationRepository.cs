using Group_Project.Models;


namespace Group_Project.Repository.IRepository
{
    public interface ICandidateExaminationRepository : IRepository<CandidateExamination>
    {
        void Update(CandidateExamination candidateExamination);

        Task<IEnumerable<CandidateExamination>> GetAllCandidateExaminationsAs();

        void UpdateCandidateQuestionAnswer(int? candidateExaminationId, int? answer);

    }
}
