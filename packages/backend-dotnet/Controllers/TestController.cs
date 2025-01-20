using Microsoft.AspNetCore.Mvc;

namespace backend_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Hello from .NET Backend!" });
    }
} 