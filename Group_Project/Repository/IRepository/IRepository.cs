using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Identity.Client;
using System.Linq.Expressions;

namespace Group_Project.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Delete(TEntity entity);
		Task<IEnumerable<TEntity>> GetAllAs();
		Task<TEntity> GetAs(int id);
		Task<TEntity> GetFirstOrDefaultAs(Expression<Func<TEntity, bool>> filter);
		Task AddAs(TEntity entity);
	}
}
