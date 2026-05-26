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
        modelBuilder.Entity<SlideApplication>(e =>
        {
            e.ToTable("applications");
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).HasColumnName("id");
            e.Property(x => x.Name).HasColumnName("name").HasMaxLength(255);
            e.Property(x => x.Description).HasColumnName("description").HasMaxLength(255);
        });

        modelBuilder.Entity<SlideEnvironment>(e =>
        {
            e.ToTable("slide_environment");
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).HasColumnName("id");
            e.Property(x => x.Name).HasColumnName("name").HasMaxLength(255);
            e.Property(x => x.Region).HasColumnName("region").HasMaxLength(255);
        });

        modelBuilder.Entity<Section>(e =>
        {
            e.ToTable("sections");
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).HasColumnName("id");
            e.Property(x => x.Name).HasColumnName("name").HasMaxLength(255);
            e.Property(x => x.ApplicationId).HasColumnName("application_id");
            e.HasOne(x => x.Application).WithMany().HasForeignKey(x => x.ApplicationId);
        });

        modelBuilder.Entity<Url>(e =>
        {
            e.ToTable("urls");
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn();
            e.Property(x => x.BaseUrl).HasColumnName("base_url").HasMaxLength(255).IsRequired();
            e.Property(x => x.ApplicationId).HasColumnName("application_id");
            e.Property(x => x.EnvironmentId).HasColumnName("environment_id");
            e.Property(x => x.Description).HasColumnName("description").HasMaxLength(255);
            e.Property(x => x.SectionId).HasColumnName("section_id");
            e.Property(x => x.Tile).HasColumnName("tile").HasMaxLength(255).IsRequired();

            e.HasOne(x => x.Application).WithMany().HasForeignKey(x => x.ApplicationId);
            e.HasOne(x => x.Environment).WithMany().HasForeignKey(x => x.EnvironmentId);
            e.HasOne(x => x.Section).WithMany().HasForeignKey(x => x.SectionId);
        });

        modelBuilder.Entity<AppHealthHistory>(e =>
        {
            e.ToTable("app_health_history");
            e.HasKey(x => x.Id);
            e.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn();
            e.Property(x => x.UrlId).HasColumnName("url_id").IsRequired();
            e.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
            e.Property(x => x.Timestamp).HasColumnName("timestamp").HasColumnType("timestamp without time zone");

            e.HasOne(x => x.Url).WithMany().HasForeignKey(x => x.UrlId).OnDelete(DeleteBehavior.Cascade);
        });
    }
}
