namespace Group_Project.Repository.IRepository
{
    public interface IUnitOfWork
    {

        ICandidateRepository Candidate { get; }
        IQuestionRepository Question { get; }
        ITopicRepository Topic { get; }
        ICertificateRepository Certificate { get; }
		IPossibleAnswersRepository PossibleAnswers { get; }
        ICandidateExaminationRepository CandidateExamination { get; }

        IQuestionAnswersRepository QuestionAnswers { get; }
		void Save();
    }
}
