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

    [HttpGet("/{id:int}")]
    public Todo GetById([FromRoute] int id, [FromServices] AppDbContext context)
    {
      return context.Todos.FirstOrDefault(x => x.Id == id);
    }

    [HttpPost("/")]
    public Todo Post([FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      context.Todos.Add(todo);
      context.SaveChanges();
      return todo;
    }

    [HttpPut("/{id:int}")]
    public Todo Put([FromRoute] int id, [FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      var model = context.Todos.FirstOrDefault(x => x.Id == id);
      if (model == null) return todo;

      model.Title = todo.Title;
      model.IsDone = todo.IsDone;

      context.Todos.Update(model);
      context.SaveChanges();
      return model;
    }

    [HttpDelete("/{id:int}")]
    public Todo Delete([FromRoute] int id, [FromServices] AppDbContext context)
    {
      var model = context.Todos.FirstOrDefault(x => x.Id == id);
      if (model == null) return todo;

      model.Title = todo.Title;
      model.IsDone = todo.IsDone;

      context.Todos.Update(model);
      context.SaveChanges();
      return model;
    }
  }
}