using FreelancerHub.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelancerHub.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Freelancer> Freelancers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Proposal> Proposals { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Define your database provider and connection string here
            optionsBuilder.UseSqlServer(
       @"Server=TAHIRA-TUFAIL\SQLEXPRESS01;Database=FreelanceHubDB;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
    

    }