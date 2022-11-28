//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  ProvidedServiceController.cs 
//PURPOSE:  This controller links the provided service data from the
//database with the views for provided services.
//INITIALIZE: This class is initiated when any data from the
//provided service is needed or if there is an action from the model ran.
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
    public class ProvideServiceController : Controller
    {
        private JasperGreenContext context { get; set; }

        public ProvideServiceController(JasperGreenContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult ProvideServiceList()
        {
            List<ProvideService> providedServices = context.ProvideServices
                .Include(e => e.Crew)
                .Include(e => e.Customer)
                .Include(e => e.Property)
                .OrderBy(e => e.ServiceID)
                .ToList();
            return View(providedServices);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Crews = context.Crews.ToList();
            ViewBag.Customers = context.Customers.ToList();
            ViewBag.Properties = context.Properties.ToList();

            return View("ProvideServiceAddEdit", new ProvideService());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Crews = context.Crews.ToList();
            ViewBag.Customers = context.Customers.ToList();
            ViewBag.Properties = context.Properties.ToList();
            var service = context.ProvideServices.Find(id);
            return View("ProvideServiceAddEdit", service);
        }

        [HttpPost]
        public IActionResult Save(ProvideService service)
        {
            if (service.ServiceID == 0)
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
                    context.ProvideServices.Add(service);
                }
                else
                {
                    context.ProvideServices.Update(service);
                }
                context.SaveChanges();
                return RedirectToAction("ProvideServiceList");
            }
            else
            {
                return View("ProvideServiceAddEdit", service);
            }
        }

        [HttpGet]
        public IActionResult ProvideServiceDelete(int id)
        {
            var service = context.ProvideServices.Find(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult ProvideServiceDelete(ProvideService service)
        {
            try
            {
                context.ProvideServices.Remove(service);
                context.SaveChanges();
            }
            catch (Exception ex) //Catches when a change cant be made due to relationships in the database
            {
                TempData["message"] = "There are one or more relationships with Employee or ProvideService that prevent deletion.";
            }
            return RedirectToAction("ProvideServiceList");
        }
    }
}
