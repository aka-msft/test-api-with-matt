using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace test_api_with_matt.Controllers
{
	[ApiController]
	[Route("[controller]")] // Takes name of class (IndexController) and removes "Controller" part
	public class IndexController : ControllerBase // Part of Microsoft.AspNetCore.Mvc
	{
		public IndexController()
        {
        }

		[HttpGet(Name = "GetIndex")] // Swagger stuff
		public IActionResult Index()
		{
            // Ok method returns IActionResult - maps to 200
            return Ok("Hello world!");
            //return StatusCode(200);
		}

        [HttpGet("time", Name = "GetTime")] // Swagger stuff
		public IActionResult Time()
		{
            return Ok(DateTime.Now);
		}
	}
}