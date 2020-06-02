using test_api_with_matt.Interfaces.Services;
using test_api_with_matt.Models;
using Microsoft.AspNetCore.Mvc;

namespace test_api_with_matt.Services
{
    public class MathService: IMathService
    {
		public int GetAdd(int x, int y)
		{
            return x + y;
		}

		public int PostAdd(MathBody body)
		{
            return body.x + body.y;
		}
    }
}