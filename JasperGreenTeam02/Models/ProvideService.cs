//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:     ProvideService.cs 
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
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class ProvideService
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "You must provide a Crew")]
        public int CrewID { get; set; } //Foreign Key
        [Required(ErrorMessage = "You must provide a Customer")]
        public int CustomerID { get; set; } //Foreign Key
        [Required(ErrorMessage = "You must provide a Property")]
        public int PropertyID { get; set; } //Foreign Key
        [Required(ErrorMessage = "You must provide a Service Date")]
        public DateTime ServiceDate { get; set; }
        [Required(ErrorMessage = "You must provide a Service Fee")]
        public double ServiceFee { get; set; }
        public int? PaymentID { get; set; } //Foreign Key


        //Navigation Properties
        public Crew Crew { get; set; }
        public Customer Customer { get; set; }
        public Property Property { get; set; }
        public Payment Payment { get; set; }

    }
}
