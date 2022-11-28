//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  CrewController.cs 
//PURPOSE:  This controller links the crew data from the
//database with the views for crews.
//INITIALIZE: This class is initiated when any data from the
//crew is needed or if there is an action from the model ran.
//INPUT:  Data from the database/context class/Views
//PROCESS:  Recieves a request to provide an action method, runs
//the method and will either alter a current view or send the user
//to another.
//OUTPUT:   Views or modifications of data represented on views.
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 

using System;
using System.Collections.Generic;
using System.Linq;
using JasperGreenTeam02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SportsPro.Controllers
{
    public class CrewController : Controller
    {
        private JasperGreenContext context { get; set; }

        public CrewController(JasperGreenContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult CrewList()
        {
            List<Crew> crews = context.Crews
                .Include(e => e.Foreman)
                .Include(e => e.CrewMember1)
                .Include(e => e.CrewMember2)
                .OrderBy(e => e.CrewID)
                .ToList();
            return View(crews);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Employees = context.Employees.ToList();

            return View("CrewAddEdit", new Crew());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Employees = context.Employees.ToList();
            var crew = context.Crews.Find(id);
            return View("CrewAddEdit", crew);
        }

        [HttpPost]
        public IActionResult Save(Crew crew)
        {
            if (crew.CrewID == 0)
            {
                ViewBag.Action = "Add";
            }
            else
            {
                ViewBag.Action = "Edit";
            }

            if (ModelState.IsValid)
            {
                if (ViewBag.Action == "Add")
                {
                    context.Crews.Add(crew);
                }
                else
                {
                    context.Crews.Update(crew);
                }
                context.SaveChanges();
                return RedirectToAction("CrewList");
            }
            else
            {
                return View("CrewAddEdit", crew);
            }
        }

        [HttpGet]
        public IActionResult CrewDelete(int id)
        {
            var crew = context.Crews.Find(id);
            return View(crew);
        }

        [HttpPost]
        public IActionResult CrewDelete(Crew crew)
        {
            try
            {
                context.Crews.Remove(crew);
                context.SaveChanges();
            }
            catch (Exception ex) //Catches when a change cant be made due to relationships in the database
            {
                TempData["message"] = "There are one or more relationships with Employee or ProvideService that prevent deletion.";
            }
            return RedirectToAction("CrewList");
        }
    }
}
