//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  Employee.cs 
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "You must provide a First Name")]
        public string EmployeeFirstName { get; set; }
        [Required(ErrorMessage = "You must provide a Last Name")]
        public string EmployeeLastName { get; set; }
        [Required(ErrorMessage = "You must provide a SSN")]
        public int SSN { get; set; }
        [Required(ErrorMessage = "You must provide a Job Title")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "You must provide a Hire Date")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "You must provide an Hourly Rate")]
        public double HourlyRate { get; set; }
        public string FullName => EmployeeFirstName + " " + EmployeeLastName;   // read-only property

        public ICollection<Crew> Crews { get; set; }
        public ICollection<Crew> Member1 { get; set; }
        public ICollection<Crew> Member2 { get; set; }
    }
}
