using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Models;

namespace Project.Data.Configurations
{
    public class SenderConfiguration : IEntityTypeConfiguration<Sender>
    {
        private const string TableName = "cd_sender";

        public void Configure(EntityTypeBuilder<Sender> builder)
        {
            builder
                .HasKey(p => p.SenderId)
                .HasName($"pk_{TableName}_sender_id");

            builder.Property(p => p.SenderId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.SenderId)
                .HasColumnName("sender_id");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("c_sender_lastname");

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("c_sender_firstname");

            builder.Property(p => p.MiddleName)
                .IsRequired()
                .HasColumnName("c_sender_middlename");

            builder.Property(p => p.Position)
                .IsRequired()
                .HasColumnName("c_sender_position");

            builder.Property(p => p.HireDate)
                .IsRequired()
                .HasColumnName("c_sender_hiredate");

            builder.ToTable(TableName);
        }
       
    }
}
