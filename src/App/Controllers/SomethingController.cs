namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SomethingController : ControllerBase
{
    [Information] // <== Using InformationAttribute
    [HttpGet("DoSomething")]
    public IActionResult DoSomething()
    {
        return Ok();
    }
}
