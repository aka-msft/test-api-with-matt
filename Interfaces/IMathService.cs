using Microsoft.AspNetCore.Mvc;
using test_api_with_matt.Models;

namespace test_api_with_matt.Interfaces.Services
{
    public interface IMathService
    {
        public int GetAdd(int x, int y);

        public int PostAdd(MathBody body);
    }
}
