using AgtechEConnect.Persistence;
using AgtechEConnect.Persistence.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AgtechEConnect.Tests.Persistence.Repositories
{
	[TestClass]
	public class ContractRepositoryTests
	{
		public ContractRepository _repository;

		[TestInitialize]
		public void Initialize()
		{
			var mockContext = new Mock<IAgtechDbContext>();
			_repository = new ContractRepository(mockContext.Object);
		}
	}
}
