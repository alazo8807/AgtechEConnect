using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AgtechEConnect.Core.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity Get(object keyValue);
		IQueryable<TEntity> GetAll();
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> searchCriteria);
	}
}
