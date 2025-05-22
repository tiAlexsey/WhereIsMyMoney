using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddDependencyInjections();

var app = builder.Build();
app.UseAppMiddlewares();
app.MapControllers();
app.Run();