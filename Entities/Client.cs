using FreelancerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace FreelancerHub.Entities
{
    public class Client : User
    {
        public string CompanyName { get; set; }

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
