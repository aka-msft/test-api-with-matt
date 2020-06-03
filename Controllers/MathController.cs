using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using test_api_with_matt.Models;
using test_api_with_matt.Interfaces.Services;

namespace test_api_with_matt.Controllers
{
	[ApiController]
	[Route("[controller]")] // Takes name of class (IndexController) and removes "Controller" part
	public class MathController : ControllerBase // Part of Microsoft.AspNetCore.Mvc
	{
        private IMathService _mathService;

		public MathController(IMathService mathService)
        {
            this._mathService = mathService;
        }

		[HttpGet("add", Name = "GetAdd")]
		public IActionResult GetAdd(int x, int y)
		{
            return Ok(this._mathService.GetAdd(x, y));
		}

        // TODO: Delete?
        // [HttpPost("add", Name = "PostAdd")]
		// public IActionResult PostAdd([FromBody] MathBody body)
		// {
        //     return Ok(this._mathService.PostAdd(body));
		// }

		[HttpGet("subtract", Name = "GetSubtract")]
		public IActionResult GetSubtract(int x, int y)
		{
            return Ok(this._mathService.GetSubtract(x, y));
		}

		[HttpGet("multiply", Name = "GetMultiply")]
		public IActionResult GetMultiply(int x, int y)
		{
            return Ok(this._mathService.GetMultiply(x, y));
		}

		[HttpGet("divide", Name = "GetDivide")]
		public IActionResult GetDivide(double x, double y)
		{
            return Ok(this._mathService.GetDivide(x, y));
		}
	}
}