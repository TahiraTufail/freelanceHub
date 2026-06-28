using FreelancerHub.Data;
using FreelancerHub.Entities;
using FreelancerHub.Repositories;

using var context = new AppDbContext();
using var unitOfWork = new UnitOfWork(context);

// ---------------- CLIENT ----------------

var client = new Client
{
    Name = "Ahmed Khan",
    Email = "ahmed@techvision.com",
    CompanyName = "Tech Vision"
};

unitOfWork.Clients.Add(client);

// ---------------- FREELANCER ----------------

var freelancer = new Freelancer
{
    Name = "Ali Raza",
    Email = "ali@gmail.com",
    Skills = "C#, ASP.NET Core, SQL Server",
    HourlyRate = 30
};

unitOfWork.Freelancers.Add(freelancer);

// Save so IDs are generated

unitOfWork.Save();

// ---------------- PROJECT ----------------

var project = new Project
{
    Title = "E-Commerce Website",
    Budget = 5000,
    Deadline = DateTime.Now.AddMonths(2)
};

unitOfWork.Projects.Add(project);

unitOfWork.Save();

// ---------------- PROPOSAL ----------------

var proposal = new Proposal
{
    FreelancerId = freelancer.Id,
    ProjectId = project.Id,
    BidAmount = 4500,
    Status = "Pending"
};

unitOfWork.Proposals.Add(proposal);

// ---------------- PAYMENT ----------------

var payment = new Payment
{
    Amount = 2000,
    PaymentDate = DateTime.Now,
    PaymentId = project.Id
};

unitOfWork.Payments.Add(payment);

// Save everything

unitOfWork.Save();

Console.WriteLine("Dummy data inserted successfully.");