using AgtechEConnect.Core;
using AgtechEConnect.Core.Dtos.Contract;
using Microsoft.AspNet.Identity;
using System;
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
			var contracts = _unitOfWork.Contracts.GetAllContractsWithCustomerVendorId().ToList();

			var userId = User.Identity.GetUserId();

			var dto = new List<ContractDto>();

			foreach (var c in contracts)
			{
				var url = string.Empty;

				try
				{
					url = UrlHelper.Link("DefaultApi", new { id = c.ContractId });
				}
				catch (Exception)
				{
					url = string.Empty;
				}

				dto.Add(new ContractDto
				{
					Url = url,
					ContractId = c.ContractId,
					ContractNo = c.ContractNo,
					CommodityId = c.CommodityId,
					ContractDate = c.ContractDate,
					LocationId = c.LocationId,
					ContractVendorCustomer = c.ContractVendorCustomer
				});
			}

			return dto;
		}

		public IHttpActionResult Get(int Id)
		{
			var contractInDb = _unitOfWork.Contracts.Get(Id);

			if (contractInDb == null)
				return NotFound();

			var url = string.Empty;

			try
			{
				url = UrlHelper.Link("DefaultApi", new { id = contractInDb.ContractId });
			}
			catch (Exception)
			{
				url = string.Empty;
			}

			var contractDto = new ContractDto()
			{
				Url = url,
				ContractId = contractInDb.ContractId,
				ContractNo = contractInDb.ContractNo,
				CommodityId = contractInDb.CommodityId,
				ContractDate = contractInDb.ContractDate,
				LocationId = contractInDb.LocationId,
				ContractVendorCustomer = contractInDb.ContractVendorCustomer
			};

			return Ok(contractDto);
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
