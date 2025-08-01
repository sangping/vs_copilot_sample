using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bmi")]
public class MyController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }

    public class BmiRequest
    {
        public double Height { get; set; } // 身高 (公分)
        public double Weight { get; set; } // 體重 (公斤)
    }

    [HttpPost]
    public IActionResult CalculateBmi([FromBody] BmiRequest request)
    {
        if (request.Height <= 0 || request.Weight <= 0)
        {
            return BadRequest("Height and Weight must be greater than zero.");
        }

        double heightInMeters = request.Height / 100.0;
        double bmi = request.Weight / (heightInMeters * heightInMeters);

        return Ok(new { bmi = Math.Round(bmi, 2) });
    }
    
}