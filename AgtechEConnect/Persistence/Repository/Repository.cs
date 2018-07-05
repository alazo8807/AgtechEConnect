using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AgtechEConnect.Core.Repositories;

namespace AgtechEConnect.Persistence.Repository
{
	public class Repository<TEntity> :IRepository<TEntity> where TEntity : class
	{
		protected DbContext _context;

		public Repository(DbContext Context)
		{
			_context = Context;
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