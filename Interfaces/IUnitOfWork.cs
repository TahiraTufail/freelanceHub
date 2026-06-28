using FreelancerHub.Entities;

namespace FreelancerHub.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Client> Clients { get; }

        IRepository<Freelancer> Freelancers { get; }

        IRepository<Project> Projects { get; }

        IRepository<Proposal> Proposals { get; }

        IRepository<Payment> Payments { get; }

        void Save();

        void Dispose();
    }
}