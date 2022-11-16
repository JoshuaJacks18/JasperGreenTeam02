using System;
using System.Collections.Generic;
using System.Linq;
using JasperGreenTeam02.Models;
using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class EmployeeController : Controller
    {
        private JasperGreenContext context { get; set; }

        public EmployeeController(JasperGreenContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult EmployeeList()
        {
            List<Employee> employees = context.Employees.OrderBy(e => e.EmployeeLastName).ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("EmployeeAddEdit", new Employee());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            var employee = context.Employees.Find(id);
            return View("EmployeeAddEdit", employee);
        }

        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            if (employee.EmployeeID == 0)
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
                    context.Employees.Add(employee);
                }
                else
                {
                    context.Employees.Update(employee);
                }
                context.SaveChanges();
                return RedirectToAction("EmployeeList");
            }
            else
            {
                return View("EmployeeAddEdit", employee);
            }
        }

        [HttpGet]
        public IActionResult EmployeeDelete(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult EmployeeDelete(Employee employee)
        {
            try
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                TempData["message"] = "There are one or more relationships with Crew or ProvideService that prevent deletion.";
            }
            return RedirectToAction("EmployeeList");
        }
    }
}
