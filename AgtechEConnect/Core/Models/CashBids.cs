using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AgtechEConnect.Core;

namespace AgtechEConnect.Core.Models
{
	/// <summary>
	/// Cash Bid entity.
	/// </summary>
	[Table("dba.ptl_cash_bids_v")]
	public partial class CashBid : IEntityBase
	{

		[Key]
		[Column("bid_sheet_nbr", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int BidSheetNbr { get; set; }

		[Key]
		[Column("commodity_id", Order = 1)]
		[StringLength(10)]
		public string CommodityId { get; set; }

		////[ForeignKey("CommodityId")]
		////public CashBidCommodity CashBidCommodity { get; set; }

		[Key]
		[Column("bid_sheet_status", Order = 2)]
		[StringLength(1)]
		public string BidSheetStatus { get; set; }

		[Key]
		[Column("price_start_date", Order = 3)]
		public DateTime PriceStartDate { get; set; }

		[Key]
		[Column("price_end_date", Order = 4)]
		public DateTime PriceEndDate { get; set; }

		[Key]
		[Column("futures_entry_flag", Order = 5)]
		[StringLength(1)]
		public string FuturesEntryFlag { get; set; }

		[Column("cp_rounding_rule_nbr")]
		public short? CashPriceRoundingRuleNbr { get; set; }

		[Column("cp_rounding_precision")]
		public short? CashPriceRoundingPrecision { get; set; }

		[Key]
		[Column("period_order", Order = 6)]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public short PeriodOrder { get; set; }

		[Key]
		[Column("delivery_start_date", Order = 7)]
		public DateTime DeliveryStartDate { get; set; }

		[Key]
		[Column("delivery_end_date", Order = 8)]
		public DateTime DeliveryEndDate { get; set; }

		[Key]
		[Column("plc_id", Order = 9)]
		[StringLength(10)]
		public string LocationId { get; set; }

		[Key]
		[Column("uom_code", Order = 10)]
		[StringLength(10)]
		public string UomCode { get; set; }

		[Column("bot_commodity_symbol")]
		[StringLength(10)]
		public string BotCommoditySymbol { get; set; }

		[Key]
		[Column("currency_code", Order = 11)]
		[StringLength(10)]
		public string CurrencyCode { get; set; }

		[Column("description")]
		[StringLength(50)]
		public string CurrencyDescription { get; set; }

		[Column("basis_price")]
		public double? BasisPrice { get; set; }

		[Column("symbol_month_year")]
		[StringLength(20)]
		public string SymbolMonthYear { get; set; }

		[Column("request_date", Order = 12)]
		public DateTime? PriceRequestDate { get; set; }

		[Column("futures_price")]
		public double? FuturesPrice { get; set; }

		[Column("delta")]
		public decimal? Delta { get; set; }

	}
}



