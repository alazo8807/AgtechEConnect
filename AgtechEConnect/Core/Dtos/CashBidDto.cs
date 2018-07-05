using System;
using System.ComponentModel.DataAnnotations;

namespace AgtechEConnect.Core.Dtos
{
	public class CashBidDto
	{
		public DateTime DeliveryStartDate { get; set; }

		public DateTime DeliveryEndDate { get; set; }

		public string UomCode { get; set; }

		public string CurrencyDescription { get; set; }

		public string CashPrice
		{
			get
			{
				switch (CashPriceRoundingRuleNbr)
				{
					case 1:	//TODO: Find proper method to round down with precision
						{
							return (Math.Round((BasisPrice.GetValueOrDefault() + FuturesPrice.GetValueOrDefault()), CashPriceRoundingPrecision.GetValueOrDefault())).ToString("N"+ CashPriceRoundingPrecision.GetValueOrDefault());
						}
					case 2: //TODO: Find proper method to round to nearest with precision
						{
							return (Math.Round((BasisPrice.GetValueOrDefault() + FuturesPrice.GetValueOrDefault()), CashPriceRoundingPrecision.GetValueOrDefault())).ToString("N" + CashPriceRoundingPrecision.GetValueOrDefault());
						}
					case 3://TODO: Find proper method to round up with precision
						{
							return (Math.Round((BasisPrice.GetValueOrDefault() + FuturesPrice.GetValueOrDefault()), CashPriceRoundingPrecision.GetValueOrDefault())).ToString("N" + CashPriceRoundingPrecision.GetValueOrDefault());
						}
					default: return (BasisPrice.GetValueOrDefault() + FuturesPrice.GetValueOrDefault()).ToString("N" + CashPriceRoundingPrecision.GetValueOrDefault());
				}
				
			}
			set { }
		}

		public double? BasisPrice { get; set; }

		[StringLength(20)]
		public string SymbolMonthYear { get; set; }

		public DateTime? PriceRequestDate { get; set; }

		public double? FuturesPrice { get; set; }

		public decimal? Delta { get; set; }

		public short? CashPriceRoundingRuleNbr { get; set; }

		public short? CashPriceRoundingPrecision { get; set; }
	}
}