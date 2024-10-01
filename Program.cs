var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet(
  "/{nome}", (string nome) =>
  {
    return Results.Ok($"Hello {nome}!");
  }
);

app.MapGet(
  "/name/{nome}", (string nome) =>
  {
    return Results.Ok($"Hello {nome}, welcome to my api!");
  }
);

app.MapPost(
  "/", (User user) =>
  {
    return Results.Ok(user);
  }
);

app.Run();

public class User
{
  public int Id { get; set; }
  public string Username { get; set; }
}