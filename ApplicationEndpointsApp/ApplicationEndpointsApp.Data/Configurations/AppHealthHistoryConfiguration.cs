using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Configurations;

public class AppHealthHistoryConfiguration : IEntityTypeConfiguration<AppHealthHistory>
{
    public void Configure(EntityTypeBuilder<AppHealthHistory> builder)
    {
        builder.ToTable("app_health_history");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        builder.Property(x => x.UrlId).HasColumnName("url_id").IsRequired();
        builder.Property(x => x.Status).HasColumnName("status").HasMaxLength(50);
        builder.Property(x => x.Timestamp).HasColumnName("timestamp").HasColumnType("timestamp without time zone");

        builder.HasOne(x => x.Url).WithMany().HasForeignKey(x => x.UrlId).OnDelete(DeleteBehavior.Cascade);
    }
}
