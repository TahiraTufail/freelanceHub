using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public int FreelancerId { get; set; }
        public int ProjectId { get; set; }
        public double BidAmount { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}
