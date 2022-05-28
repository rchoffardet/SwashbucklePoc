using Microsoft.AspNetCore.Mvc;

namespace SwashbucklePoc.Controllers;

[ApiController]
[Route("greets")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public Greeting Get()
    {
        return new Greeting("world");
    }
}