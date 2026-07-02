using SkillBridge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SkillBridge.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Freelancer> Freelancers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Proposal> Proposals { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Client → Projects (1-to-many)
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            // Freelancer → Proposals (1-to-many)
            modelBuilder.Entity<Proposal>()
                .HasOne(pr => pr.Freelancer)
                .WithMany(f => f.Proposals)
                .HasForeignKey(pr => pr.FreelancerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Project → Proposals (1-to-many)
            modelBuilder.Entity<Proposal>()
                .HasOne(pr => pr.Project)
                .WithMany(p => p.Proposals)
                .HasForeignKey(pr => pr.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Project → Payments (1-to-many)
            modelBuilder.Entity<Payment>()
                .HasOne(pay => pay.Project)
                .WithMany(p => p.Payments)
                .HasForeignKey(pay => pay.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}