using AgtechEConnect.Core.Models;
using System.Collections.Generic;

namespace AgtechEConnect.Core.Repositories
{
	public interface IContractRepository : IRepository<Contract>
	{
		IEnumerable<Contract> GetAllContractsWithCustomerVendorId();
	}
}
