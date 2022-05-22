using FRMK.Models.Responses;
using FRML.API.UoW;
using Microsoft.AspNetCore.Mvc;

namespace FRML.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly CalculatorUoW _calculatorUoW;
        public CalculatorController(CalculatorUoW calculatorUoW, ILogger<CalculatorController> logger)
        {
            _calculatorUoW = calculatorUoW;
            _logger = logger;
        }

        [HttpGet(Name = "GetDivisorsAndPrimeDivisors")]
        public DivisorsResponse GetDivisorsAndPrimeDivisors([FromQuery] int number)
        {
            var response = _calculatorUoW.Calculator.GetDivisorsAndPrimeDivisors(number);
                return response;
        }
    }
}