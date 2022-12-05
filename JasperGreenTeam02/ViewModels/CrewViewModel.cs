using JasperGreenTeam02.Models;
using System.Collections.Generic;

namespace JasperGreenTeam02.ViewModels
{
    public class CrewViewModel
    {
        public int CrewID { get; set; }
        public Crew Crew { get; set; }
        public int ForemanID { get; set; }
        public Employee Foreman { get; set; }
        public int CrewMember1ID { get; set; }
        public Employee CrewMember1 { get; set; }
        public int CrewMember2ID { get; set; }
        public Employee CrewMember2 { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
