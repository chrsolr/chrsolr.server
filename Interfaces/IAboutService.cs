namespace chrsolr_api.Interfaces;

public interface IAboutService
{
    public Task<AboutDTO> GetAboutMe();
}
