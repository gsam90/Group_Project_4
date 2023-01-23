using Group_Project.Models;

namespace Group_Project.Repository.IRepository
{
	public interface ITopicRepository : IRepository<Topic>
	{
		void Update(QuestionAnswers questionAnswers);
	}
}
