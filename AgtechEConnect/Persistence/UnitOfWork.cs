using AgtechEConnect.Core;
using AgtechEConnect.Core.Repositories;
using AgtechEConnect.Persistence.Repository;

namespace AgtechEConnect.Persistence
{
	public class UnitOfWork : IUnitOfWork
	{
		public IContractRepository Contracts { get; private set; }
		public ICashBidRepository CashBids { get; private set; }
		public ICashBidCommoditiesRepository CashBidCommodities { get; private set; }
		public ICashBidLocationsRepository CashBidLocations { get; private set; }

		private readonly AgtechDbContext _context;

		public UnitOfWork(AgtechDbContext context)
		{
			_context = context;
			Contracts = new ContractRepository(_context);
			CashBids = new CashBidRepository(_context);
			CashBidCommodities = new CashBidCommoditiesRepository(_context);
			CashBidLocations = new CashBidLocationsRepository(_context);
		}

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}