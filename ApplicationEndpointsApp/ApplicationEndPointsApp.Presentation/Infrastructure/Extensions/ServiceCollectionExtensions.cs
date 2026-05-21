using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.Services;
using ApplicationEndpointsApp.Data.Contracts;
using ApplicationEndpointsApp.Data.Context;
using ApplicationEndpointsApp.Data.Repositories;

namespace ApplicationEndpointsApp.Presentation.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IApplicationEndpointRepository, ApplicationEndpointRepository>();
        services.AddScoped<IApplicationEndpointsService, ApplicationEndpointService>();

        // Todo add logging and monitoring

        // Todo add cors and rate limiting
        // services.AddCors();
        // services.AddRateLimiter();

        // Todo add Authentication and Authorization
        // services.AddAuthentication();
        // services.AddAuthorization();

        return services;
    }
}
