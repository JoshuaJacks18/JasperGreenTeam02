using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } //Navigation Property
        [Required]
        public string PropertyAddress { get; set; }
        [Required]
        public string PropertyCity { get; set; }
        [Required]
        public string PropertyState { get; set; }
        [Required]
        public string PropertyZIP { get; set; }
        [Required]
        public string ServiceFee { get; set; }

        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
