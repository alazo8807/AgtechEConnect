using AgtechEConnect.Core.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AgtechEConnect.Core.Repositories;

namespace AgtechEConnect.Persistence.Repository
{
	public class ContractRepository : Repository<Contract>, IContractRepository
	{
		public ContractRepository(AgtechDbContext context)
			: base(context)
		{
		}

		public AgtechDbContext AgtechContext {
			get { return _context as AgtechDbContext; }
		}

		public IEnumerable<Contract> GetAllContractsWithCustomerVendorId()
		{
			return AgtechContext.Contracts.Include(c => c.ContractVendorCustomer).ToList();
		}
	}
}