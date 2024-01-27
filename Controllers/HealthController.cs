using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HealthController : ControllerBase
{
    [HttpGet("health")]
    public ActionResult<dynamic> GetVersion()
    {
        var version = GetType().Assembly.GetName().Version.ToString();
        var name = GetType().Assembly.GetName().Name.ToString();

        return Ok(new { name, version });
    }
}
