using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public int ProjectId { get; set; }
    }
}
