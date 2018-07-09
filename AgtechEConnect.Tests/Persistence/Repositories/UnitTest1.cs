using AgtechEConnect.Core.Models;
using AgtechEConnect.Persistence;
using AgtechEConnect.Persistence.Repository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AgtechEConnect.Tests.Persistence.Repositories
{
	[TestClass]
	public class ContractRepositoryTests
	{
		private Mock<DbSet<Contract>> _mockContracts;
		private Mock<IAgtechDbContext> _mockContext;
		private ContractRepository _repo;

		[TestInitialize]
		public void Initialize()
		{
			_mockContracts = new Mock<DbSet<Contract>>();

			_mockContext = new Mock<IAgtechDbContext>();

			_repo = new ContractRepository(_mockContext.Object);
		}

		[TestMethod]
		public void GetAllContractsWithCustomerVendorId_WhenCalled_ReturnContractsWithCustomerVendorPopulated()
		{
			var contract = new Contract()
			{
				ContractId = 47,
				ContractVendorCustomer = new NameAndAddress() { Id = "100" }
			};

			_mockContracts = SetSource((new List<Contract>() {contract}));

			_mockContracts.Setup(c => c.Include("ContractVendorCustomer")).Returns(_mockContracts.Object);

			_mockContext.SetupGet(m => m.Contracts).Returns(_mockContracts.Object);

			var result = _repo.GetAllContractsWithCustomerVendorId();

			result.Should().NotBeNullOrEmpty();
		}

		private Mock<DbSet<T>> SetSource<T>(IList<T> entities) where T : class
		{
			var data = entities.AsQueryable();

			var mockSet = new Mock<DbSet<T>>();
			mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
			mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
			mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
			mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
			return mockSet;
		}

	}
}
