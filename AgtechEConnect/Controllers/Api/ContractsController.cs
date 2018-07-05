using AgtechEConnect.Core;
using AgtechEConnect.Core.Dtos.Contract;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace AgtechEConnect.Controllers.Api
{
	public class ContractsController : ApiController
	{
		IUnitOfWork _unitOfWork;

		UrlHelper _urlHelper;

		public ContractsController()
		{
		}

		public ContractsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			//_unitOfWork = new UnitOfWork(new AgtechDbContext());
		}

		public IEnumerable<ContractDto> GetContracts()
		{
			var contracts = _unitOfWork.Contracts.GetAll().ToList();

			var userId = User.Identity.GetUserId();

			var dto = new List<ContractDto>();

			foreach (var c in contracts)
			{
				dto.Add(new ContractDto
				{
					Url = UrlHelper.Link("DefaultApi", new { id = c.ContractId }),
					ContractId = c.ContractId,
					ContractNo = c.ContractNo,
					CommodityId = c.CommodityId,
					ContractDate = c.ContractDate,
					LocationId = c.LocationId,
					VendorCustomerId = c.VendorCustomerId,
				});
			}

			return dto;
		}

		public UrlHelper UrlHelper //Using defered execution. At this point the request should exist. 
		{
			get
			{
				if (_urlHelper == null)
					_urlHelper = new UrlHelper(this.Request);

				return _urlHelper;
			}
			set { }
		}
	}
}
