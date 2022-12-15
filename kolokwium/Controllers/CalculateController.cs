using kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculateController : ControllerBase
    {
        [HttpGet]
        public int Add(int a, int b)
        {
            var calc = new Calculator();
            return calc.Add(a,b);
        }
        [HttpGet]
        public float Divide(int a, int b)
        {
            var calc = new Calculator();
            return calc.Divide(a, b);
        }
        [HttpGet]
        public int Substract(int a, int b)
        {
            var calc = new Calculator();
            return calc.Substract(a, b);
        }
        [HttpGet]
        public int Multiply(int a, int b)
        {
            var calc = new Calculator();
            return calc.Multiply(a, b);
        }
    };
}
