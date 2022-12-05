//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  CrewViewModel.cs 
//PURPOSE:  This view model passes data between the CrewController
//and the Crew Add/Edit view.
//INITIALIZE: This class is initiated when the add/edit crew view is opened.
//INPUT:  References from opening of a crew view.
//PROCESS:  Data is referenced in the add/edit crew view and the data is passed
//to the view by the view model.
//OUTPUT:   Data passed to the add/edit crew view.
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 
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
