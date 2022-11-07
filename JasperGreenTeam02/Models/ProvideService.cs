using System;
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class ProvideService
    {
        public int ServiceID { get; set; }
        [Required]
        public int CrewID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int PropertyID { get; set; }
        [Required]
        public DateTime ServiceDate { get; set; }
        [Required]
        public double ServiceFee { get; set; }
        public int PaymentID { get; set; }


        //Navigation Properties
        public Crew Crew { get; set; }
        public Customer Customer { get; set; }
        public Property Property { get; set; }
        public Payment Payment { get; set; }

    }
}
