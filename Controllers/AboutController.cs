using Microsoft.AspNetCore.Mvc;

namespace chrsolr_api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AboutController : ControllerBase
{
    private readonly ILogger<AboutController> _logger;
    private readonly IAboutService _aboutService;

    public AboutController(ILogger<AboutController> logger, IAboutService aboutService)
    {
        _logger = logger;
        _aboutService = aboutService;
    }

    [HttpGet(Name = "GetAbout")]
    public async Task<ActionResult<AboutDTO>> Get()
    {
        AboutDTO about = await _aboutService.GetAboutMe();
        return Ok(about);
    }
}
