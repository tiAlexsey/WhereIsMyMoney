namespace WebApi.Extensions;

public static class AppMiddlewareExtensions
{
    public static void UseAppMiddlewares(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.UseAuthorization();
    }
}