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
            catch (Exception ex)
            {
                TempData["message"] = "There are one or more relationships with Employee or ProvideService that prevent deletion.";
            }
            return RedirectToAction("CrewList");
        }
    }
}
