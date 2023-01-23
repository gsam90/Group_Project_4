using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
	public class ExamQuestion
	{
		public int Id { get; set; }
		public ExamTopics ExamTopics { get; set; }
		public QuestionAnswers QuestionAnswer {get; set;}

	}
}