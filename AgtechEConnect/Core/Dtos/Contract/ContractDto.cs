using System;

namespace AgtechEConnect.Core.Dtos.Contract
{
	public class ContractDto
	{
		public string Url { get; set; }

		public int ContractId { get; set; }

		public int ContractNo { get; set; }

		public string CommodityId { get; set; }

		public DateTime? ContractDate { get; set; }

		public string LocationId { get; set; }

		public string VendorCustomerId { get; set; }
	}
}