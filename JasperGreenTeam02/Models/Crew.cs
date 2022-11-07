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
        public int CrewForemanID { get; set; }

        [Required]
        [ForeignKey("EmployeeID")]
        public int CrewMember1ID { get; set; }

        [Required]
        [ForeignKey("EmployeeID")]
        public int CrewMember2ID { get; set; }
        
        
        //Navigation Properties
        public Employee Foreman { get; set; }
        public Employee CrewMember1 { get; set; }
        public Employee CrewMember2 { get; set; }
        public ICollection<ProvideService> ProvidedServices { get; set; }
    }
}
