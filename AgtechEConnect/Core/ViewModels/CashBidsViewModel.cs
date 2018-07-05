using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AgtechEConnect.Core.Dtos;
using AgtechEConnect.Core.Models;

namespace AgtechEConnect.Core.ViewModels
{
	public class CashBidsViewModel
	{
		[Display(Name = "Location")]
		public string LocationId { get; set; }

		[Display(Name = "Commodity")]
		public string CommodityId { get; set; }

		public int BidSheetNbr { get; set; }

		public string Uom { get; set; }

		public string Currency { get; set; }

		public DateTime priceDate { get; set; }

		public IEnumerable<CashBidLocation> CashBidLocations { get; set; }

		public IList<CashBidCommodityDto> CashBidCommodities { get; set; }

		public IList<CashBidDto> CashBidsPerPeriod { get; set; }

		public bool IsGridVisible { get; set; }
	}
}