using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public virtual DbSet<Url> Urls { get; set; }
    public virtual DbSet<SlideApplication> SlideApplications { get; set; }
    public virtual DbSet<SlideEnvironment> SlideEnvironments { get; set; }
    public virtual DbSet<Section> Sections { get; set; }
    public virtual DbSet<AppHealthHistory> AppHealthHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
