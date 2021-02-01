using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.Controllers
{
[Route("api/command")]
[ApiController]
public class CommandsController : ControllerBase
{
[HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
return new string[] {"this", "is", "hard", "coded"};
}
[HttpGet("emma")]
public ActionResult<IEnumerable<string>> GetMe()
{
return new string[] {"this", "look", "hard", "coded"};
}
}
}

