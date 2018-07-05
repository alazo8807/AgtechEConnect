using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgtechEConnect.Core.Models
{
	[Table("dba.ptl_location_cashbid_v")]
	public partial class CashBidLocation
	{
		[Key]
		[Column("location_id", Order = 0)]
		[StringLength(10)]
		public string LocationID { get; set; }

		[Key]
		[Column("country_description", Order = 1)]
		[StringLength(20)]
		public string CountryDescription { get; set; }

		[Key]
		[Column("parent_location_id", Order = 2)]
		[StringLength(10)]
		public string ParentLocationID { get; set; }

		[Column("state_province_code")]
		[StringLength(3)]
		public string StateProvinceCode { get; set; }

		[Column("address_line_1")]
		[StringLength(250)]
		public string AddressLine1 { get; set; }

		[Column("address_line_2")]
		[StringLength(250)]
		public string AddressLine2 { get; set; }

		[Column("city")]
		[StringLength(32)]
		public string City { get; set; }

		[Column("currency")]
		[StringLength(50)]
		public string Currency { get; set; }

		[Key]
		[Column("full_name", Order = 3)]
		[StringLength(50)]
		public string FullName { get; set; }

		[Column("short_name")]
		[StringLength(10)]
		public string ShortName { get; set; }

		[Column("zip_postal_code")]
		[StringLength(10)]
		public string ZipPostalCode { get; set; }
	}
}