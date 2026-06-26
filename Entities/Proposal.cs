using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public int FriendId { get; set; }
        public int ProjectId { get; set; }
        public double bidAmount { get; set; }
        public string Status { get; set; }

    }
}
