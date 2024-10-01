using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public List<Todo> Get([FromServices] AppDbContext context)
      => context.Todos.ToList();
    [HttpPost("/")]
    public Todo Post([FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      context.Todos.Add(todo);
      context.SaveChanges();
      return todo;
    }
  }
}