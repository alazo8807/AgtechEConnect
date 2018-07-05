namespace AgtechEConnect.Core.Dtos
{
	public class CashBidCommodityDto
	{
		public string CommodityID { get; set; }

		public string DisplayName {
			get
			{
				return string.Format("{0} - {1}", CommodityID, CommodityName);
			}
			set {}
		}

		public string CommodityName { get; set; }
	}
}