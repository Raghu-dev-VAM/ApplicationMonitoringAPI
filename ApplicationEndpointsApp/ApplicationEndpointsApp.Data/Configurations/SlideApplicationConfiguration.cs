using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Configurations;

public class SlideApplicationConfiguration : IEntityTypeConfiguration<SlideApplication>
{
    public void Configure(EntityTypeBuilder<SlideApplication> builder)
    {
        builder.ToTable("applications");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(255);
        builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(255);
    }
}
