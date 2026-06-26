using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancerHub.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentId { get; set; }

    }
}
