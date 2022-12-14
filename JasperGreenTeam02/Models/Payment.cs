//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:     Payment.cs 
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        [Required]
        public int CustomerID { get; set; } //Foreign Key
        public Customer Customer { get; set; } //Navigation Property

        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public Double PaymentAmount { get; set; }
        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
