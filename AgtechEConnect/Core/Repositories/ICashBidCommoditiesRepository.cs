using AgtechEConnect.Core.Models;
using System.Collections.Generic;

namespace AgtechEConnect.Core.Repositories
{
	public interface ICashBidCommoditiesRepository : IRepository<CashBidCommodity>
	{
		IEnumerable<CashBidCommodity> GetAllCashbidsCommodities();
	}
}
