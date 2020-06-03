using Microsoft.AspNetCore.Mvc;
using test_api_with_matt.Models;

namespace test_api_with_matt.Interfaces.Services
{
    public interface IMathService
    {
        public int GetAdd(int x, int y);

        // TODO: Delete?
        // public int PostAdd(MathBody body);

        public int GetSubtract(int x, int y);

        public int GetMultiply(int x, int y);

        public double GetDivide(double x, double y);
    }
}
