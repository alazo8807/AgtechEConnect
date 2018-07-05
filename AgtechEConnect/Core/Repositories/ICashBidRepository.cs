using AgtechEConnect.Core.Models;
using System.Collections.Generic;

namespace AgtechEConnect.Core.Repositories
{
	public interface ICashBidRepository : IRepository<CashBid>
	{
		//IEnumerable<CashBid> GetAllCashbidsWithCommodity();

		IEnumerable<CashBid> GetCashBidByBidSheetNbr(int Id);

		IEnumerable<CashBid> GetCashBidByCommodityAndLocation(string commodity, string location);

		IEnumerable<CashBid> GetAllActiveCashBids();
	}
}
