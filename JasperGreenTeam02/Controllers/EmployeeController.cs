//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  EmployeeController.cs 
//PURPOSE:  This controller links the employee data from the
//database with the views for employees.
//INITIALIZE: This class is initiated when any data from the
//employee is needed or if there is an action from the model ran.
//INPUT:  Data from the database/context class/Views
//PROCESS:  Recieves a request to provide an action method, runs
//the method and will either alter a current view or send the user
//to another.
//OUTPUT:   Views or modifications of data represented on views.
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 

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

            if (ModelState.IsValid) //Checking validation
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
                return View("EmployeeAddEdit", employee); ////There was a validation error and is sent back to the edit page
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
