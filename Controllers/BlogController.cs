using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/blog")]
public class BlogController : ControllerBase
{
    private readonly ILogger<BlogController> _logger;
    private readonly IBlogPostService _blogPostService;

    public BlogController(ILogger<BlogController> logger, IBlogPostService blogPostService)
    {
        _logger = logger;
        _blogPostService = blogPostService;
    }

    [HttpGet]
    public async Task<ActionResult<List<BlogPostDTO>>> Get()
    {
        var post = await _blogPostService.GetAll();
        return Ok(post);
    }
}
