using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public Double PaymentAmount { get; set; }
        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
