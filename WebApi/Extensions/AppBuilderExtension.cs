namespace WebApi.Extensions;

public static class AppBuilderExtension
{
    public static void AddDependencyInjections(this IHostApplicationBuilder builder)
    {
        builder.Services.AddControllers();
    }
}