using FreelancerHub.Data;
using FreelancerHub.Entities;
using FreelancerHub.Repositories;

using var context = new AppDbContext();
var unitOfWork = new UnitOfWork(context);


// ======================= CLIENTS =======================

var client1 = new Client
{
    Name = "Ahmed Khan",
    Email = "ahmed@techvision.com",
    CompanyName = "Tech Vision"
};

var client2 = new Client
{
    Name = "Sarah Ali",
    Email = "sarah@softworks.com",
    CompanyName = "Soft Works"
};

var client3 = new Client
{
    Name = "Usman Tariq",
    Email = "usman@futurelabs.com",
    CompanyName = "Future Labs"
};

unitOfWork.Clients.Add(client1);
unitOfWork.Clients.Add(client2);
unitOfWork.Clients.Add(client3);



// ======================= FREELANCERS =======================

var freelancer1 = new Freelancer
{
    Name = "Ali Raza",
    Email = "ali@gmail.com",
    Skills = "C#, ASP.NET Core, SQL",
    HourlyRate = 30
};

var freelancer2 = new Freelancer
{
    Name = "Ayesha Noor",
    Email = "ayesha@gmail.com",
    Skills = "React, JavaScript",
    HourlyRate = 25
};

var freelancer3 = new Freelancer
{
    Name = "Bilal Ahmed",
    Email = "bilal@gmail.com",
    Skills = "Python, AI, Machine Learning",
    HourlyRate = 45
};

var freelancer4 = new Freelancer
{
    Name = "Hamza Khan",
    Email = "hamza@gmail.com",
    Skills = "Flutter, Firebase",
    HourlyRate = 35
};

unitOfWork.Freelancers.Add(freelancer1);
unitOfWork.Freelancers.Add(freelancer2);
unitOfWork.Freelancers.Add(freelancer3);
unitOfWork.Freelancers.Add(freelancer4);


// Save to generate IDs

unitOfWork.Save();



// ======================= PROJECTS =======================

var project1 = new Project
{
    Title = "E-Commerce Website",
    Budget = 5000,
    Deadline = DateTime.Now.AddMonths(2)
};

var project2 = new Project
{
    Title = "AI Resume Analyzer",
    Budget = 8000,
    Deadline = DateTime.Now.AddMonths(1)
};

var project3 = new Project
{
    Title = "Food Delivery App",
    Budget = 6000,
    Deadline = DateTime.Now.AddMonths(3)
};

var project4 = new Project
{
    Title = "Hospital Management System",
    Budget = 12000,
    Deadline = DateTime.Now.AddMonths(5)
};

var project5 = new Project
{
    Title = "Portfolio Website",
    Budget = 2000,
    Deadline = DateTime.Now.AddDays(20)
};

unitOfWork.Projects.Add(project1);
unitOfWork.Projects.Add(project2);
unitOfWork.Projects.Add(project3);
unitOfWork.Projects.Add(project4);
unitOfWork.Projects.Add(project5);

unitOfWork.Save();



// ======================= PROPOSALS =======================

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer1.Id,
    ProjectId = project1.Id,
    BidAmount = 4500,
    Status = "Accepted"
});

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer2.Id,
    ProjectId = project1.Id,
    BidAmount = 4700,
    Status = "Rejected"
});

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer3.Id,
    ProjectId = project2.Id,
    BidAmount = 7500,
    Status = "Accepted"
});

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer1.Id,
    ProjectId = project3.Id,
    BidAmount = 5500,
    Status = "Pending"
});

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer4.Id,
    ProjectId = project3.Id,
    BidAmount = 5300,
    Status = "Accepted"
});

unitOfWork.Proposals.Add(new Proposal
{
    FreelancerId = freelancer2.Id,
    ProjectId = project5.Id,
    BidAmount = 1800,
    Status = "Pending"
});



// ======================= PAYMENTS =======================

unitOfWork.Payments.Add(new Payment
{
    Amount = 2000,
    PaymentDate = DateTime.Now,
    PaymentId = project1.Id
});

unitOfWork.Payments.Add(new Payment
{
    Amount = 5000,
    PaymentDate = DateTime.Now,
    PaymentId = project2.Id
});

unitOfWork.Payments.Add(new Payment
{
    Amount = 1500,
    PaymentDate = DateTime.Now,
    PaymentId = project3.Id
});

unitOfWork.Payments.Add(new Payment
{
    Amount = 6000,
    PaymentDate = DateTime.Now,
    PaymentId = project4.Id
});

unitOfWork.Payments.Add(new Payment
{
    Amount = 1000,
    PaymentDate = DateTime.Now,
    PaymentId = project5.Id
});



unitOfWork.Save();

Console.WriteLine("Dummy data inserted successfully.");