public class AuthService : IAuthService
{
    private readonly DataContext _context;
    private readonly IConfiguration _configuration;

    public AuthService(DataContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public async Task<string> Login(string email, string password)
    {
        var user = await _context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
        if (user is null)
        {
            return null;
        }

        var userVerified = AuthUtils.VerifyPassword(password, user.Password, user.Salt);
        if (!userVerified)
        {
            return null;
        }

        return AuthUtils.GenerateToken(user);
    }

    public async Task<string> Register(string email, string username, string password)
    {
        var existentUser = await _context.Users.AnyAsync(u => u.Email == email || u.Username == username);
        if (existentUser)
        {
            return null;
        }

        (string Hash, string Salt) enc = AuthUtils.CreatePasswordHash(password);

        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = string.Empty,
            LastName = string.Empty,
            NickName = string.Empty,
            Email = email,
            Username = username,
            ImageUrl = string.Empty,
            Password = enc.Hash,
            Salt = enc.Salt,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        var result = await _context.Users.AddAsync(user);
        _context.SaveChanges();


        Console.WriteLine($"existentUser ({existentUser})");
        Console.WriteLine($"result ({result})");
        Console.WriteLine($"username ({user.Username})");

        return AuthUtils.GenerateToken(user);
    }
}
