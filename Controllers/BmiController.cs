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
}