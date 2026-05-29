using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Configurations;

public class UrlConfiguration : IEntityTypeConfiguration<Url>
{
    public void Configure(EntityTypeBuilder<Url> builder)
    {
        builder.ToTable("urls");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn();
        builder.Property(x => x.BaseUrl).HasColumnName("base_url").HasMaxLength(255).IsRequired();
        builder.Property(x => x.ApplicationId).HasColumnName("application_id");
        builder.Property(x => x.EnvironmentId).HasColumnName("environment_id");
        builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(255);
        builder.Property(x => x.SectionId).HasColumnName("section_id");
        builder.Property(x => x.Tile).HasColumnName("tile").HasMaxLength(255).IsRequired();

        builder.HasOne(x => x.Application).WithMany().HasForeignKey(x => x.ApplicationId);
        builder.HasOne(x => x.Environment).WithMany().HasForeignKey(x => x.EnvironmentId);
        builder.HasOne(x => x.Section).WithMany().HasForeignKey(x => x.SectionId);
    }
}
