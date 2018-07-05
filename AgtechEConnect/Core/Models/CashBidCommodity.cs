using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgtechEConnect.Core.Models
{
	/// <summary>
	/// Cash Bid Commodities.
	/// </summary>
	[Table("dba.ptl_commodity_cashbid_v")]
	public partial class CashBidCommodity : IEntityBase
	{
		//[Key]
		//[Column(Order = 0)]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		//public long RowId { get; set; }

		[Key]
		[Column("commodity_id")]
		[StringLength(10)]
		public string CommodityID { get; set; }

		[Column("name")]
		[StringLength(50)]
		public string CommodityName { get; set; }
	}
}
