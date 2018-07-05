using AgtechEConnect.Core.Models;
using AgtechEConnect.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AgtechEConnect.Persistence.Repository
{
	public class CashBidCommoditiesRepository : Repository<CashBidCommodity>, ICashBidCommoditiesRepository
	{
		public CashBidCommoditiesRepository(AgtechDbContext context)
			: base(context)
		{
		}

		public AgtechDbContext AgtechContext
		{
			get { return _context as AgtechDbContext; }
		}

		public IEnumerable<CashBidCommodity> GetAllCashbidsCommodities()
		{
			return AgtechContext.CashBidCommodities.ToList();
		}
	}
}