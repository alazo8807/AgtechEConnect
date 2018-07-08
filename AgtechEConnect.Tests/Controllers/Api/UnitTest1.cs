using AgtechEConnect.Controllers.Api;
using AgtechEConnect.Core;
using AgtechEConnect.Core.Dtos.Contract;
using AgtechEConnect.Core.Models;
using AgtechEConnect.Core.Repositories;
using AgtechEConnect.Tests.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Web.Http.Results;

namespace AgtechEConnect.Tests.Controllers.Api
{
	[TestClass]
	public class ContractsControllerTest
	{
		private ContractsController _controller;
		private Mock<IContractRepository> _mockRepository;

		[TestInitialize]
		public void Initialize()
		{
			_mockRepository = new Mock<IContractRepository>();
			var mockUoW = new Mock<IUnitOfWork>();

			mockUoW.SetupGet(u => u.Contracts).Returns(_mockRepository.Object);

			_controller = new ContractsController(mockUoW.Object);
			_controller.MockCurrentUser("1", "user1@domain.com");
			_controller.Request = new System.Net.Http.HttpRequestMessage()
			{
				RequestUri = new Uri("http://localhost:64979/api/contracts/1")
			};
		}

		[TestMethod]
		public void Get_NotValidId_ReturnNotFound()
		{
			var result = _controller.Get(-111);

			result.Should().BeOfType<NotFoundResult>();
		}

		[TestMethod]
		public void Get_ValidId_ReturnOk()
		{
			var contract = new Contract()
			{
				ContractId = 1
			};

			_mockRepository.Setup(r => r.Get(1)).Returns(contract);

			var result = _controller.Get(1);

			result.Should().BeOfType<OkNegotiatedContentResult<ContractDto>>();
		}
	}
}
