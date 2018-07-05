using System.Collections.Generic;
using System.Web.Http;
using AgtechEConnect.Core;
using AgtechEConnect.Core.Dtos;
using AgtechEConnect.Core.Models;

namespace AgtechEConnect.Controllers.Api
{
	public class CashBidsController : ApiController
	{
		private IUnitOfWork _unitOfWork;

		public CashBidsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			//_unitOfWork = new UnitOfWork(new AgtechDbContext());
		}

		public IEnumerable<CashBidDto> GetCashBids(string commodity = null, string location = null)
		{
			var cashBids = new List<CashBid>();
				 
			if (!string.IsNullOrWhiteSpace(commodity) && !string.IsNullOrWhiteSpace(location))
			{
				cashBids = _unitOfWork.CashBids.GetCashBidByCommodityAndLocation(commodity, location) as List<CashBid>;
			}
			else
			{
				cashBids = _unitOfWork.CashBids.GetAllActiveCashBids() as List<CashBid>;
			}

			var result = new List<CashBidDto>();

			foreach (var cashBid in cashBids)
			{   //TODO: Set up Automapper to do this
				result.Add(new CashBidDto
				{
					DeliveryStartDate = cashBid.DeliveryStartDate,
					DeliveryEndDate = cashBid.DeliveryEndDate,
					UomCode = cashBid.UomCode,
					CurrencyDescription = cashBid.CurrencyDescription,
					BasisPrice = cashBid.BasisPrice,
					SymbolMonthYear = cashBid.SymbolMonthYear,
					PriceRequestDate = cashBid.PriceRequestDate,
					FuturesPrice = cashBid.FuturesPrice,
					Delta = cashBid.Delta,
					CashPriceRoundingRuleNbr = cashBid.CashPriceRoundingRuleNbr,
					CashPriceRoundingPrecision = cashBid.CashPriceRoundingPrecision
				});
			}

			return result;
		}

	}
}
