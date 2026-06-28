using FreelancerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace FreelancerHub.Entities
{
    public class Client : User
    {
        public required string CompanyName { get; set; } = string.Empty;

        public override string GetRole()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Client: {Name}, Company: {CompanyName}";
        }
    }
}
