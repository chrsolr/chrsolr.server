using Microsoft.AspNetCore.Mvc;

namespace chrsolr_api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AboutController : ControllerBase
{
    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAbout")]
    public ActionResult<About> Get()
    {
        return Ok(new About());
    }
}
