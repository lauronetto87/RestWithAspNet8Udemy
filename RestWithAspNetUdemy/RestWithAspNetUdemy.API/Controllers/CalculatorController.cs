using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestWithAspNetUdemy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        // GET: api/<CalculatorController>
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);

                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        // GET: api/<CalculatorController>
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var subtraction = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);

                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        // GET: api/<CalculatorController>
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var division = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);

                return Ok(division.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        // GET: api/<CalculatorController>
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var multiplication = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);

                return Ok(multiplication.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        // GET: api/<CalculatorController>
        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var media = (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)) / 2;

                return Ok(media.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        [HttpGet("square/{firstNumber}")]
        public IActionResult Square(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var square = Math.Sqrt((double)Convert.ToDecimal(firstNumber));

                return Ok(square.ToString());
            }
            return BadRequest("Invalid Inout");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                                            strNumber,
                                            System.Globalization.NumberStyles.Any,
                                            System.Globalization.CultureInfo.InvariantCulture,
                                            out number);
            return isNumber;
        }
    }
}