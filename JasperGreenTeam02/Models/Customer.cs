using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZIP { get; set; }
        public string CustomerPhone { get; set; }

    }
}
