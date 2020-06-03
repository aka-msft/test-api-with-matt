using test_api_with_matt.Interfaces.Services;
using test_api_with_matt.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace test_api_with_matt.Services
{
    public class MathService: IMathService
    {
		public int GetAdd(int x, int y)
		{
            return x + y;
		}

        // // TODO: Delete?
		// public int PostAdd(MathBody body)
		// {
        //     return body.x + body.y;
		// }

        public int GetSubtract(int x, int y)
        {
            return x - y;
        }

        public int GetMultiply(int x, int y)
        {
            return x * y;
        }

        public double GetDivide(double x, double y)
        {
            return Math.Round((x / y), 2);
        }
    }
}