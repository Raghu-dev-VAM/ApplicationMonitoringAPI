using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Configurations;

public class SlideEnvironmentConfiguration : IEntityTypeConfiguration<SlideEnvironment>
{
    public void Configure(EntityTypeBuilder<SlideEnvironment> builder)
    {
        builder.ToTable("slide_environment");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(255);
        builder.Property(x => x.Region).HasColumnName("region").HasMaxLength(255);
    }
}
