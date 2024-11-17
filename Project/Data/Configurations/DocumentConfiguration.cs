using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Models;

namespace Project.Data.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        private const string TableName = "cd_document";

        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder
                .HasKey(p => p.DocumentId)
                .HasName($"pk_{TableName}_document_id");

            builder.Property(p => p.DocumentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("document_id");

            builder.Property(p => p.DocumentNumber)
                .IsRequired()
                .HasColumnName("c_document_number");

            builder.Property(p => p.RegistrationDate)
                .IsRequired()
                .HasColumnName("c_document_registrationdate");

            builder.Property(p => p.Summary)
                .IsRequired()
                .HasColumnName("c_document_summary");

            builder.Property(p => p.DocumentType)
                .IsRequired()
                .HasColumnName("c_document_type");

            builder.Property(p => p.SenderId)
                .IsRequired()
                .HasColumnName("c_document_sender_id");

            builder.Property(p => p.RecipientOrganizationId)
                .IsRequired()
                .HasColumnName("c_document_recipient_organization_id");

            builder.ToTable(TableName)
                .HasOne(p => p.Sender)
                .WithMany()
                .HasForeignKey(p => p.SenderId)
                .HasConstraintName("fk_f_sender_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasOne(p => p.RecipientOrganization)
                .WithMany()
                .HasForeignKey(p => p.RecipientOrganizationId)
                .HasConstraintName("fk_f_recipient_organization_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Navigation(p => p.Sender)
                .AutoInclude();

            builder.Navigation(p => p.RecipientOrganization)
                .AutoInclude();
        }
    }
}
