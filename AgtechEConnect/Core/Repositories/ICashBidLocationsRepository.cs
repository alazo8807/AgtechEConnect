using AgtechEConnect.Core.Models;
using System.Collections.Generic;

namespace AgtechEConnect.Core.Repositories
{
	public interface ICashBidLocationsRepository : IRepository<CashBidLocation>
	{
		IEnumerable<CashBidLocation> GetAllCashbidsLocations();
	}
}
