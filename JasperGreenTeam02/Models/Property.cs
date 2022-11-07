using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } //Navigation Property
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZIP { get; set; }
        public string ServiceFee { get; set; }
    }
}
