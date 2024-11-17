using Microsoft.EntityFrameworkCore;
using Project.Data.Configurations;
using Project.Models;

namespace Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<Sender> Senders { get; set; }
        DbSet<RecipientOrganization> Organizations { get; set; }
        DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SenderConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new RecipientOrganizationConfiguration());
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
    }
}
