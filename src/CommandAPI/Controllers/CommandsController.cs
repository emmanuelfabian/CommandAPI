using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.Controllers
{
[Route("api/emma")]
[ApiController]
public class CommandsController : ControllerBase
{
[HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
return new string[] {"this", "is", "hard", "coded"};
}
}
}