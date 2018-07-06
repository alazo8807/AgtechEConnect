using AgtechEConnect.Controllers.Api;
using AgtechEConnect.Core;
using AgtechEConnect.Tests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AgtechEConnect.Tests.Controllers.Api
{
	[TestClass]
	public class ContractsControllerTest
	{
		private ContractsController _controller;

		public ContractsControllerTest()
		{
			var mockUoW = new Mock<IUnitOfWork>();

			//Object is the actual implementation of UnitOfWork
			_controller = new ContractsController(mockUoW.Object);
			_controller.MockCurrentUser("1", "user1@domain.com");
		}

		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
