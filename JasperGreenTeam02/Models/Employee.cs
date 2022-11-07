using System;
using System.Collections.Generic;

namespace JasperGreenTeam02.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int SSN { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
        public double HourlyRate { get; set; }

        public ICollection<Crew> Crews { get; set; }
        public ICollection<Crew> Member1 { get; set; }
        public ICollection<Crew> Member2 { get; set; }
    }
}
