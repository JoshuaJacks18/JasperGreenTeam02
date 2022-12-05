//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  Customer.cs 
//PURPOSE:  The Model is used to help store the data from
//  the database within an object.
//INITIALIZE: This class is initialized when the OnModelCreating()
//  method is ran within the JasperGreenContext.cs
//INPUT:  Data from the database/context class
//PROCESS:  Retrives the data from the database and creates
//  an object with the relative properties
//OUTPUT:   Objects with the appropriate/related data
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "You must provide a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a Billing Address")]
        public string BillingAddress { get; set; }
        [Required(ErrorMessage = "You must provide a City")]
        public string BillingCity { get; set; }
        [Required(ErrorMessage = "You must provide a State")]
        public string BillingState { get; set; }
        [Required(ErrorMessage = "You must provide a Zip Code")]
        [RegularExpression(@"([0-9]{5}(?:-[0-9]{4}))?$", ErrorMessage = "Zipcode must be formated as 99999 or 99999-9999")] //Creates a requirment for formating
        public string BillingZIP { get; set; }
        [Required(ErrorMessage = "You must provide a Phone Number")]
        [RegularExpression(@"^\(([0-9]{3})\)[ ]([0-9]{3})[-]([0-9]{4})$", ErrorMessage = "Phone Number must be formated as (999) 999-9999")] //Creates a requirment for formating
        public string CustomerPhone { get; set; }

        public ICollection<ProvideService> ProvidedServices { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
