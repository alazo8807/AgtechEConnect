using AgtechEConnect.Core.Models;
using System.Collections.Generic;
using System.Linq;
using AgtechEConnect.Core.Repositories;


namespace AgtechEConnect.Persistence.Repository
{
	public class CashBidLocationsRepository : Repository<CashBidLocation>, ICashBidLocationsRepository
	{
		public CashBidLocationsRepository(AgtechDbContext context)
			: base(context)
		{
		}

		public AgtechDbContext AgtechContext
		{
			get { return _context as AgtechDbContext; }
		}

		public IEnumerable<CashBidLocation> GetAllCashbidsLocations()
		{
			return AgtechContext.CashBidLocations.ToList();
		}
	}
}