using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JWT
{
    private readonly IConfiguration _configuration;

    public JWT(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string GenerateToken(string username)
    {
        List<Claim> claims = new List<Claim>{
            new Claim(ClaimTypes.Name, username),
            new Claim("OTHERSTUFF", "EXTRA")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            _configuration.GetSection("JWT:Key").Value!
        ));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}