using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Repository
{
	public class TopicRepository : Repository<Topic>, ITopicRepository
	{
		private readonly MyDbContext _context;
		public TopicRepository(MyDbContext context) : base(context)
		{
			_context = context;
		}

		public void Update(QuestionAnswers questionAnswer)
		{
			_context.Update(questionAnswer);
		}
	}
}
