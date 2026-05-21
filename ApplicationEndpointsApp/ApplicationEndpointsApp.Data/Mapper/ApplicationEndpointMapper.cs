using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Configurations;

public class ApplicationEndpointConfiguration : IEntityTypeConfiguration<ApplicationEndpoints>
{
    public void Configure(EntityTypeBuilder<ApplicationEndpoints> entity)
    {
        entity.ToTable("applications");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("id").UseMySqlIdentityColumn();
        entity.Property(e => e.ApplicationName).HasColumnName("name");        
        entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(255);        
    }
}
