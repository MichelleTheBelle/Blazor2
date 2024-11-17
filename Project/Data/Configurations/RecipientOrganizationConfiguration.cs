using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Models;

namespace Project.Data.Configurations
{
    public class RecipientOrganizationConfiguration : IEntityTypeConfiguration<RecipientOrganization>
    {
        private const string TableName = "cd_recipient_organization";

        public void Configure(EntityTypeBuilder<RecipientOrganization> builder)
        {
            builder
                .HasKey(p => p.RecipientOrganizationId)
                .HasName($"pk_{TableName}_organization_id");

            builder.Property(p => p.RecipientOrganizationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("recipient_organization_id");

            builder.Property(p => p.ShortName)
                .IsRequired()
                .HasColumnName("c_organization_shortname");

            builder.Property(p => p.FullName)
                .IsRequired()
                .HasColumnName("c_organization_fullname");

            builder.Property(p => p.LegalAddress)
                .IsRequired()
                .HasColumnName("c_organization_legaladdress");

            builder.Property(p => p.Phone)
                .HasColumnName("c_organization_phone");

            builder.Property(p => p.DirectorFullName)
                .IsRequired()
                .HasColumnName("c_organization_directorfullname");

            builder.ToTable(TableName);
        }
    }
}
