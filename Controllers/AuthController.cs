using System.Security.Cryptography;
using System.Text;
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
        string password = userLoginDTO.Password;

        SHA256 hash = SHA256.Create();
        byte[] key = hash.ComputeHash(Encoding.ASCII.GetBytes(password));
        byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

        string enc = AES.Encrypt(password, key, iv);
        string dec = AES.Decrypt(enc, key, iv);

        Console.WriteLine($"{enc} - {dec}");

        var token = new JWT(_configuration).GenerateToken(userLoginDTO.Username);
        return Ok(token);
    }
}
