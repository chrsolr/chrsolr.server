namespace chrsolr_api.Interfaces;

public interface IAuthService
{
    public Task<string> Register(string email, string username, string password);
    public Task<string> Login(string email, string password);
}
