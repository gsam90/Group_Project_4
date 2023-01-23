namespace Group_Project.Models
{
    public class CandidateExamination
    {
        public int Id { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Exam Exam { get; set; }
        
        public int? CandidateQuestionAnswer { get; set; }
        public ExamQuestion ExamQuestion { get; set; }
        public int? QuestionResult { get; set; }

        public DateTime ExamStartingTime { get; set; }
        public DateTime timestamp { get; set; }

        
    }
}
