using AgtechEConnect.Controllers.Api;
using AgtechEConnect.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace AgtechEConnect.Tests.Controllers.Api
{
	[TestClass]
	public class ContractsControllerTest
	{
		private ContractsController _controller;

		public ContractsControllerTest()
		{
			var identity = new GenericIdentity("user1@domain.com");
			identity.AddClaim(
				new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name)", "user1@domain.com"));
			identity.AddClaim(
				new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier)", "1"));

			var principal = new GenericPrincipal(identity, null);

			var mockUoW = new Mock<IUnitOfWork>();

			//Object is the actual implementation of UnitOfWork
			_controller = new ContractsController(mockUoW.Object);
			_controller.User = principal;
		}

		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
