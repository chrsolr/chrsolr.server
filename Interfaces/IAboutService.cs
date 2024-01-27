namespace chrsolr.Interfaces;

public interface IAboutService
{
    public Task<AboutDTO> GetAboutMe();
}
