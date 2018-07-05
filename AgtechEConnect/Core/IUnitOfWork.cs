using System;
using AgtechEConnect.Core.Repositories;

namespace AgtechEConnect.Core
{
	public interface IUnitOfWork : IDisposable
	{
		IContractRepository Contracts { get; }
		ICashBidRepository CashBids { get; }
		ICashBidCommoditiesRepository CashBidCommodities { get; }
		ICashBidLocationsRepository CashBidLocations { get; }

		int Complete();
	}
}
