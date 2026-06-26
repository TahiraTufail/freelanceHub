using FreelancerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Freelancer : User
    {
        public string Skills { get; set; }
        public double HourlyRate { get; set; }

        public override string GetRole()
        {
            throw new NotImplementedException();
        }
    }
}
