using Infrastructure;

namespace WebApi.Extensions;

public static class AppBuilderExtension
{
    public static void AddDependencyInjections(this IHostApplicationBuilder builder)
    {
        builder.Configuration.AddEnvironmentVariables();

        builder.Services.AddCors();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHealthChecks();
        
        builder.AddInfrastructure();
    }
}