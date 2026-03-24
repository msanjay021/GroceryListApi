using GroceryList.Models.Entities;
using GroceryList.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GroceryList.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class GroceryController : ControllerBase
	{
		private readonly IGrocery _grocery;
		private readonly List<Grocery> groceries = new List<Grocery>();

		public GroceryController(Grocery grocery)
		{
			grocery = new Grocery
			{
				Id = 1,
				Name = "orange",
				Price = 25,
				Quantity = 2
			};
			_grocery = grocery;
		}

		[HttpGet]
		public IActionResult Get()
		{

			return Ok(_grocery);
		}

		[HttpGet("{id:int}")]
		public IActionResult GetById(int id) 
		{
			return Ok();
		}
		[HttpPost("{id:int}")]
		public IActionResult Post(int id)
		{
			return Ok();
		}
		[HttpPut("{id:int}")]
		public IActionResult Update(int id)
		{
			return Ok();
		}
		[HttpDelete("{id:int}")]
		public IActionResult Delete(int id)
		{
			return Ok();
		}
	}
}
