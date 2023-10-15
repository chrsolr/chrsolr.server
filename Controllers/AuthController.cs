using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IConfiguration _configuration;

    public AuthController(ILogger<AuthController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpPost("login")]
    public ActionResult<string> Login(UserLoginDTO userLoginDTO)
    {
        var token = new JWT(_configuration).GenerateToken(userLoginDTO.Username);
        return Ok(token);
    }
}
