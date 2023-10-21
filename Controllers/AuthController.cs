using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IAuthService _authService;

    public AuthController(ILogger<AuthController> logger, IAuthService authService)
    {
        _logger = logger;
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(UserLoginDTO user)
    {
        var token = await _authService.Login(user.Email, user.Password);
        if (token is null)
        {
            return Unauthorized();
        }

        return Ok(token);
    }

    [HttpPost("register")]
    public async Task<ActionResult<string>> Register(UserRegisterDTO user)
    {
        var token = await _authService.Register(user.Email, user.Username, user.Password);
        if (token is null)
        {
            return Conflict();
        }

        return Ok(token);
    }
}
