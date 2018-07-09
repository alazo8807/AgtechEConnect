using AgtechEConnect.Core.Models;
using AgtechEConnect.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AgtechEConnect.Persistence.Repository
{
	public class ContractRepository : Repository<Contract>, IContractRepository
	{
		public ContractRepository(IAgtechDbContext context)
			: base(context)
		{
		}

		//public AgtechDbContext AgtechContext {
		//	get { return _context as AgtechDbContext; }
		//}

		public IEnumerable<Contract> GetAllContractsWithCustomerVendorId()
		{
			return _context.Contracts.Include(c => c.ContractVendorCustomer).ToList();
			//return _context.Contracts.ToList();
			//return AgtechContext.Contracts.Include(c => c.Location).ToList();
		}
	}
}