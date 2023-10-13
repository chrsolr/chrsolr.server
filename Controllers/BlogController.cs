using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/blog")]
public class BlogController : ControllerBase
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<dynamic>> Get()
    {
        return Ok("Ok");
    }
}