using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost("login")]
    public ActionResult<string> Login(UserLoginDTO userLoginDTO)
    {
        Console.WriteLine($"{userLoginDTO.Username}-{userLoginDTO.Password}");
        return Ok("TOKEN HERE");
    }
}
