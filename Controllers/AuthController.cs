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
    public ActionResult<string> Login(UserLoginDTO user)
    {
        // do this in service
        // find user
        // verify pass
        // return token
        var hash = "6MNWsac35QE0GMi0j1w7gEjB3K0hTwHM/WSSXq/DeJs=";
        var salt = "+XUXnnmbI1bFh3I8y3oBxIS3RO+wcBpWgbciESQBNcj183c7QbBN7H5GL6Mqxda+pFn/2Oyl0CitSdGa7a+DLw==";
        var passwordVerified = AuthUtils.VerifyPassword(user.Password, hash, salt);

        if (!passwordVerified)
        {
            return Unauthorized();
        }

        var token = new JWT(_configuration).GenerateToken(user.Email);
        return Ok(token);
    }

    [HttpPost("register")]
    public ActionResult<dynamic> Register(UserRegisterDTO user)
    {
        (string Hash, string Salt) enc = AuthUtils.CreatePasswordHash(user.Password);

        // verify user does not exist and register user
        // if success create and return token

        var token = new JWT(_configuration).GenerateToken(user.Username);
        return Ok(token);
    }
}
