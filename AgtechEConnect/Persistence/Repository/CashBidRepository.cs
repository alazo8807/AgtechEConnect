using AgtechEConnect.Core.Models;
using System.Collections.Generic;
using System.Linq;
using AgtechEConnect.Core.Repositories;

namespace AgtechEConnect.Persistence.Repository
{
	public class CashBidRepository : Repository<CashBid>, ICashBidRepository
	{
		public CashBidRepository(AgtechDbContext context)
			:base(context)
		{
		}

		public AgtechDbContext AgtechContext
		{
			get { return _context as AgtechDbContext; }
		}

		//public IEnumerable<CashBid> GetAllCashbidsWithCommodity()
		//{
		//	return AgtechContext.CashBids.Include(c => c.CashBidCommodity).ToList();
		//}

		public IEnumerable<CashBid> GetCashBidByBidSheetNbr(int Id)
		{
			return AgtechContext.CashBids.Where(cb => cb.BidSheetNbr == Id).ToList();
		}

		public IEnumerable<CashBid> GetAllActiveCashBids()
		{
			return AgtechContext.CashBids
					.Where(cb => cb.BidSheetStatus == "A")
					.ToList();
		}

		public IEnumerable<CashBid> GetCashBidByCommodityAndLocation(string commodity, string location)
		{
			return AgtechContext.CashBids
					.Where(cb => cb.CommodityId == commodity && cb.LocationId == location && cb.BidSheetStatus == "A")
					.ToList();
		}
	}
}