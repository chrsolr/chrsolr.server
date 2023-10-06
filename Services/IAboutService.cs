namespace chrsolr_api.Services;

public interface IAboutService
{
    public Task<AboutDTO> GetAboutMe();
}
