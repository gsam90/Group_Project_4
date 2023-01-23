namespace Group_Project.Repository.IRepository
{
    public interface IUnitOfWork
    {

        ICandidateRepository Candidate { get; }
        ITopicRepository Topic { get; }
        ICertificateRepository Certificate { get; }
        ICandidateExaminationRepository CandidateExamination { get; }

        IExamQuestionRepository ExamQuestion { get; }
        IQuestionAnswersRepository QuestionAnswers { get; }
		void Save();
    }
}
