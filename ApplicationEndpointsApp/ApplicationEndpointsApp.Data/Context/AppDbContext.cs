using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Models;
using ApplicationEndpointsApp.Data.Configurations;

namespace ApplicationEndpointsApp.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public virtual DbSet<ApplicationEndpoints> ApplicationEndpoints { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ApplicationEndpointConfiguration());
    }
}
