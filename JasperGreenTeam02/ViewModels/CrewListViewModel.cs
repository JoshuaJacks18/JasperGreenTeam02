//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  CrewListViewModel.cs 
//PURPOSE:  This view model passes data between the CrewController
//and the Crew List view.
//INITIALIZE: This class is initiated when the Manage Crew view is opened.
//INPUT:  References from opening of a crew view.
//PROCESS:  Data is referenced in the manage crew view and the data is passed
//to the view by the view model.
//OUTPUT:   Data passed to the manage crew view.
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 
using JasperGreenTeam02.Models;
using System.Collections.Generic;

namespace JasperGreenTeam02.ViewModels
{
    public class CrewListViewModel
    {
        public List<Crew> Crews { get; set; }
    }
}
