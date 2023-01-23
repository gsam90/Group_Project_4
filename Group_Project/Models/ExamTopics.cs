namespace Group_Project.Models
{
	public class ExamTopics
	{
		public int Id { get; set; }
		public virtual Topic Topic { get; set; }
		public virtual Exam Exam { get; set; }
	}
}
