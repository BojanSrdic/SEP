using Business_Logic_Layer.DTOs;
using Business_Logic_Layer.Services;
using Data_Access_Layer.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionInfoController : ControllerBase
	{
		private readonly ITransactionHandler _handler;
		public TransactionInfoController(ITransactionHandler handler)
		{
			_handler = handler;

		}

		[HttpPost]
		public IActionResult Create(CreateTransaction model)
		{
			_handler.CreateTransaction(model);

			return Ok("Food created successfully");
		}

		[HttpGet]
		public IActionResult GetList()
		{
			return Ok(_handler.GetAll());
		}

	}
}
