using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "Hello World!";
    }
  }
}