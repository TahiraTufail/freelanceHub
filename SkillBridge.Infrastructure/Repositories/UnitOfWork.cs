using SkillBridge.Infrastructure.Data;
using SkillBridge.Domain.Entities;
using SkillBridge.Domain.Interfaces;

namespace SkillBridge.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;

        public IRepository<Client> Clients { get; }
        public IRepository<Freelancer> Freelancers { get; }
        public IRepository<Project> Projects { get; }
        public IRepository<Proposal> Proposals { get; }
        public IRepository<Payment> Payments { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Clients = new Repository<Client>(context);
            Freelancers = new Repository<Freelancer>(context);
            Projects = new Repository<Project>(context);
            Proposals = new Repository<Proposal>(context);
            Payments = new Repository<Payment>(context);
        }

        public async Task<int> SaveAsync()
            =>await _context.SaveChangesAsync();    

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}