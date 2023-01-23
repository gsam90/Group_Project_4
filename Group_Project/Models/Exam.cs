namespace Group_Project.Models
{
	public class Exam
	{
		public int Id { get; set; }
		public virtual Certificate Certificate { get; set; }

        public virtual ICollection<ExamTopics> Topic { get; set; }
        public int SubjectWeight { get; set; }
        public virtual ICollection<ExamQuestion>? ExamQuestions { get; set; }
        public DateTime ExamDuration { get; set; }
    }
}
