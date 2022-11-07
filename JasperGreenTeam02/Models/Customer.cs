using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public string BillingCity { get; set; }
        [Required]
        public string BillingState { get; set; }
        [Required]
        public string BillingZIP { get; set; }
        [Required]
        public string CustomerPhone { get; set; }

        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
