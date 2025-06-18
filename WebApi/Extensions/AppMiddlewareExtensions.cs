namespace WebApi.Extensions;

public static class AppMiddlewareExtensions
{
    public static void UseAppMiddlewares(this WebApplication app)
    {
        app.UseRouting();
        app.UseCors(options => { options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapHealthChecks("/health");
    }
}