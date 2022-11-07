using System;

namespace JasperGreenTeam02.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime PaymentDate { get; set; }
        public Double PaymentAmount { get; set; }
    }
}
