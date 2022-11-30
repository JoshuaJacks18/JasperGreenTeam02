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
using Microsoft.AspNetCore.Http;
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
            HttpContext.Session.Remove("CustID");
            HttpContext.Session.Remove("PropID");
            HttpContext.Session.Remove("CrewID");
            List<ProvideService> providedServices = context.ProvideServices
                .Include(e => e.Crew)
                .Include(e => e.Customer)
                .Include(e => e.Property)
                .OrderBy(e => e.ServiceID)
                .ToList();
            return View(providedServices);
        }

        public IActionResult ListByCustomer(Customer cust)
        {
            if (cust.CustomerID == 0)
            {
                Customer placeHolder = context.Customers.Find(HttpContext.Session.GetInt32("CustID"));
                ViewBag.Filter = placeHolder.Name;
            }
            else
            {
                Customer placeHolder = context.Customers.Find(cust.CustomerID);
                HttpContext.Session.SetInt32("CustID", cust.CustomerID);
                ViewBag.Filter = placeHolder.Name;
            }


            List<ProvideService> providedServices = context.ProvideServices
                .Include(e => e.Crew)
                .Include(e => e.Customer)
                .Include(e => e.Property)
                .OrderBy(e => e.ServiceID)
                .ToList();
            return View(providedServices);
        }

        public IActionResult ListByProperty(Property property)
        {
            if (property.PropertyID == 0)
            {
                Property placeHolder = context.Properties.Find(HttpContext.Session.GetInt32("PropID"));
                ViewBag.Filter = placeHolder.PropertyAddress;
            }
            else
            {
                Property placeHolder = context.Properties.Find(property.PropertyID);
                HttpContext.Session.SetInt32("PropID", property.PropertyID);
                ViewBag.Filter = placeHolder.PropertyAddress;
            }


            List<ProvideService> providedServices = context.ProvideServices
                .Include(e => e.Crew)
                .Include(e => e.Customer)
                .Include(e => e.Property)
                .OrderBy(e => e.ServiceID)
                .ToList();
            return View(providedServices);
        }
        public IActionResult ListByCrew(Crew crew)
        {
            if (crew.CrewID == 0)
            {
                Crew placeHolder = context.Crews.Find(HttpContext.Session.GetInt32("CrewID"));
                ViewBag.Filter = placeHolder.CrewID;
            }
            else
            {
                Crew placeHolder = context.Crews.Find(crew.CrewID);
                HttpContext.Session.SetInt32("CrewID", crew.CrewID);
                ViewBag.Filter = placeHolder.CrewID;
            }


            List<ProvideService> providedServices = context.ProvideServices
                .Include(e => e.Crew)
                .Include(e => e.Customer)
                .Include(e => e.Property)
                .OrderBy(e => e.ServiceID)
                .ToList();
            return View(providedServices);
        }
        public IActionResult Return()
        {
            if (HttpContext.Session.Get("CrewID") != null){
                return RedirectToAction("ListByCrew");
            }
            if (HttpContext.Session.Get("PropID") != null)
            {
                return RedirectToAction("ListByProperty");
            }
            if (HttpContext.Session.Get("CustID") != null)
            {
                return RedirectToAction("ListByCustomer");
            }
            return RedirectToAction("ProvideServiceList");
        }




            [HttpGet]
        public IActionResult GetCustomer()
        {
            HttpContext.Session.Remove("CustID");
            HttpContext.Session.Remove("PropID");
            HttpContext.Session.Remove("CrewID");

            List<Customer> customers = context.Customers.OrderBy(t => t.Name).ToList();

            ViewBag.Customers = customers;

            return View(new Customer());
        }

        [HttpGet]
        public IActionResult GetCrew()
        {
            //HttpContext.Session.SetString("CustomerName", "name");
            HttpContext.Session.Remove("CustID");
            HttpContext.Session.Remove("PropID");
            HttpContext.Session.Remove("CrewID");

            List<Crew> crews = context.Crews.OrderBy(t => t.CrewID).ToList();

            ViewBag.Crews = crews;

            return View(new Crew());
        }

        [HttpGet]
        public IActionResult GetProperty()
        {
            //HttpContext.Session.SetString("CustomerName", "name");
            HttpContext.Session.Remove("CustID");
            HttpContext.Session.Remove("PropID");
            HttpContext.Session.Remove("CrewID");

            List<Property> properties = context.Properties.OrderBy(t => t.PropertyID).ToList();

            ViewBag.Properties = properties;

            return View(new Property());
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
                return RedirectToAction("Return");
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
            return RedirectToAction("Return");
        }
    }
}
