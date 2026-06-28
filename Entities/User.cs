using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public abstract class User
    {
        public int Id { get; set; } 

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public abstract string GetRole();
    }
}