using AgtechEConnect.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AgtechEConnect.Persistence.Repository
{
	public class Repository<TEntity> :IRepository<TEntity> where TEntity : class
	{
		protected IAgtechDbContext _context;

		public Repository(IAgtechDbContext context)
		{
			_context = context;
		}

		public TEntity Get(object keyValue)
		{
			return _context.Set<TEntity>().Find(keyValue);
		}

		public IQueryable<TEntity> GetAll()
		{
			return _context.Set<TEntity>();
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> searchCriteria)
		{
			return _context.Set<TEntity>().Where(searchCriteria);
		}
	}
}