//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  Crew.cs 
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

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JasperGreenTeam02.Models
{
    public class Crew
    {
        public int CrewID { get; set; }
        
        [ForeignKey("EmployeeID")]
        [InverseProperty("Crews")]
        [Required]
        public int CrewForemanID { get; set; } //Foreign Key

        [Required]
        [ForeignKey("EmployeeID")]
        public int CrewMember1ID { get; set; } //Foreign Key

        [Required]
        [ForeignKey("EmployeeID")]
        public int CrewMember2ID { get; set; } //Foreign Key


        //Navigation Properties
        public Employee Foreman { get; set; }
        public Employee CrewMember1 { get; set; }
        public Employee CrewMember2 { get; set; }
        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
