using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JasperGreenTeam02.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeFirstName { get; set; }
        [Required]
        public string EmployeeLastName { get; set; }
        [Required]
        public int SSN { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public double HourlyRate { get; set; }

        public ICollection<Crew> Crews { get; set; }
        public ICollection<Crew> Member1 { get; set; }
        public ICollection<Crew> Member2 { get; set; }
    }
}
