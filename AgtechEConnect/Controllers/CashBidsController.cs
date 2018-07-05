using System.Collections.Generic;
using System.Web.Mvc;
using AgtechEConnect.Core;
using AgtechEConnect.Core.Dtos;
using AgtechEConnect.Core.ViewModels;

namespace AgtechEConnect.Controllers
{
	public class CashBidsController : Controller
	{
		private IUnitOfWork _unitOfWork;

		public CashBidsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			//_unitOfWork = new UnitOfWork(new AgtechDbContext());
		}

		public ActionResult Details()
		{
			//var commodities = _unitOfWork.CashBidCommodities.GetAll().ToList();

			var viewModel = new CashBidsViewModel
			{
				CashBidsPerPeriod = new List<CashBidDto>(),
				CashBidLocations = _unitOfWork.CashBidLocations.GetAllCashbidsLocations(),
				CashBidCommodities = new List<CashBidCommodityDto>()
			};

			var commodities = _unitOfWork.CashBidCommodities.GetAllCashbidsCommodities();

			foreach (var commodity in commodities)
			{
				viewModel.CashBidCommodities.Add(new CashBidCommodityDto
				{
					CommodityID = commodity.CommodityID,
					CommodityName = commodity.CommodityName
				});
			}
			return View("Details", viewModel);
		}


		// GET: CashView
		//public ActionResult Details(int id)
		//{
		//	var cashBids = _unitOfWork.CashBids.GetCashBidByBidSheetNbr(id);

		//	var viewModel = new CashBidsViewModel
		//	{
		//		CommodityId = cashBids.FirstOrDefault().CommodityId,
		//		LocationId = cashBids.FirstOrDefault().LocationId,
		//		CashBidsPerPeriod = new List<CashBidDto>(),
		//		CashBidLocations = _unitOfWork.CashBidLocations.GetAllCashbidsLocations(),
		//		CashBidCommodities = _unitOfWork.CashBidCommodities.GetAllCashbidsCommodities()
		//	};

		//	foreach (var cashBid in cashBids)
		//	{	//TODO: Set up Automapper to do this
		//		viewModel.CashBidsPerPeriod.Add(new CashBidDto
		//		{
		//			DeliveryStartDate = cashBid.DeliveryStartDate,
		//			DeliveryEndDate = cashBid.DeliveryEndDate,
		//			BasisPrice = cashBid.BasisPrice,
		//			SymbolMonthYear = cashBid.SymbolMonthYear,
		//			FuturesPrice = cashBid.FuturesPrice,
		//			Delta = cashBid.Delta,
		//			CashPriceRoundingRuleNbr = cashBid.CashPriceRoundingRuleNbr,
		//			CashPriceRoundingPrecision = cashBid.CashPriceRoundingPrecision
		//		});
		//	}

		//	return View(viewModel);
		//}
	}
}
