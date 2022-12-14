//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:     Property.cs 
//PURPOSE:  The Model is used to help store the data from
//          the database within an object.
//INITIALIZE: This class is initialized when the OnModelCreating()
//          method is ran within the JasperGreenContext.cs
//INPUT:    Data from the database/context class
//PROCESS:  Retrives the data from the database and creates
//          an object with the relative properties
//OUTPUT:   Objects with the appropriate/related data
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        [Required(ErrorMessage = "You must provide a Customer")]
        public int CustomerID { get; set; } //Foreign Key
        public Customer Customer { get; set; } //Navigation Property
        [Required(ErrorMessage = "You must provide an Address")]
        public string PropertyAddress { get; set; }
        [Required(ErrorMessage = "You must provide a City")]
        public string PropertyCity { get; set; }
        [Required(ErrorMessage = "You must provide a State")]
        public string PropertyState { get; set; }
        [Required(ErrorMessage = "You must provide a Zip Code")]
        public string PropertyZIP { get; set; }
        [Required(ErrorMessage = "You must provide a Service Fee")]
        public double ServiceFee { get; set; }

        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
