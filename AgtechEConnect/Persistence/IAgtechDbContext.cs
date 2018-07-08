using AgtechEConnect.Core.Models;
using System.Data.Entity;

namespace AgtechEConnect.Persistence
{
	public interface IAgtechDbContext
	{
		DbSet<CashBidCommodity> CashBidCommodities { get; set; }
		DbSet<CashBidLocation> CashBidLocations { get; set; }
		DbSet<CashBid> CashBids { get; set; }
		DbSet<Contract> Contracts { get; set; }
		DbSet<NameAndAddress> NameAndAddress { get; set; }
	}
}