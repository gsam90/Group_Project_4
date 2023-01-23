using Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Data
{
	public class MyDbContext : DbContext
	{

		public MyDbContext(DbContextOptions options): base(options)
		{

		}
		DbSet<Candidate> Candidates { get; set; }
		DbSet<CandidateCertificate> CandidateCertificates { get; set; }
		DbSet<Certificate> Certificates { get; set; }
		DbSet<ExamQuestion> ExamQuestions { get; set; }
		DbSet<Exam> Exams { get; set; }
		DbSet<ExamTopics> ExamTopics { get; set; }
		DbSet<Topic> Topics { get; set; }

		DbSet<CandidateExamination> CandidateExaminations { get; set; }
		
		DbSet<QuestionAnswers> QuestionAnswers { get; set; }
	}

	
}

