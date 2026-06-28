using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public double Budget { get; set; }

        public DateTime Deadline { get; set; }
    }
}
