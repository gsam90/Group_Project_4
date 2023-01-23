using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;

namespace Group_Project.Repository
{
	public class PossibleAnswersRepository : Repository<PossibleAnswers>, IPossibleAnswersRepository
	{
		private readonly MyDbContext _context;
		public PossibleAnswersRepository(MyDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(Certificate certificate)

		{
			_context.Update(certificate);
		}
	}
}
