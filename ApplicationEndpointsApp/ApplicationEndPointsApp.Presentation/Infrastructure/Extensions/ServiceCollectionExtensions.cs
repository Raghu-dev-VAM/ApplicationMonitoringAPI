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
            options.UseNpgsql(connectionString));

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUrlRepository, UrlRepository>();
        services.AddScoped<ISlideApplicationRepository, SlideApplicationRepository>();
        services.AddScoped<ISlideEnvironmentRepository, SlideEnvironmentRepository>();
        services.AddScoped<ISectionRepository, SectionRepository>();
        services.AddScoped<IAppHealthHistoryRepository, AppHealthHistoryRepository>();

        services.AddScoped<IUrlService, UrlService>();
        services.AddScoped<ISlideApplicationService, SlideApplicationService>();
        services.AddScoped<ISlideEnvironmentService, SlideEnvironmentService>();
        services.AddScoped<ISectionService, SectionService>();
        services.AddScoped<IAppHealthHistoryService, AppHealthHistoryService>();

        return services;
    }
}
