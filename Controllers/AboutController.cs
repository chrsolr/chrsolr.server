using Microsoft.AspNetCore.Mvc;

namespace chrsolr_api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AboutController : ControllerBase
{
    private readonly ILogger<AboutController> _logger;
    private readonly IAbout _about;

    public AboutController(ILogger<AboutController> logger, IAbout about)
    {
        _logger = logger;
        _about = about;
    }

    [HttpGet(Name = "GetAbout")]
    public async Task<ActionResult<About>> Get()
    {
        About about = await _about.GetAboutMe();
        return Ok(about);
    }
}
