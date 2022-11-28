//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  PropertyController.cs 
//PURPOSE:  This controller links the property data from the
//database with the views for properties.
//INITIALIZE: This class is initiated when any data from the
//property is needed or if there is an action from the model ran.
//INPUT:  Data from the database/context class/Views
//PROCESS:  Recieves a request to provide an action method, runs
//the method and will either alter a current view or send the user
//to another.
//OUTPUT:   Views or modifications of data represented on views.
//HONOR CODE: “On my honor, as an Aggie, I have neither given  
//   nor received unauthorized aid on this academic  
//   work.” 

using JasperGreenTeam02.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JasperGreenTeam02.Controllers
{
    public class PropertyController : Controller
    {
        private JasperGreenContext context { get; set; }

        public PropertyController(JasperGreenContext ctx)
        {
            context = ctx;
        }

        public IActionResult PropertyList()
        {
            List<Property> properties = context.Properties
                .Include(p => p.Customer)
                .ToList();
            return View(properties);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Customers = context.Customers.ToList();
            ViewBag.Action = "Add";
            return View("PropertyAddEdit", new Property());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Customers = context.Customers.ToList();
            ViewBag.Action = "Edit";
            var property = context.Properties.Find(id);
            return View("PropertyAddEdit", property);
        }

        [HttpPost]
        public IActionResult Save(Property property)
        {
            if (ModelState.IsValid) //Checking validation
            {
                if (property.PropertyID == 0)
                {
                    context.Properties.Add(property);
                }
                else
                {
                    context.Properties.Update(property);
                }
                context.SaveChanges();
                return RedirectToAction("PropertyList"); //Completed successfully
            }
            else
            {
                ViewBag.Customers = context.Customers.ToList();
                if (property.PropertyID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View("PropertyAddEdit",property); //There was a validation error and is sent back to the edit page
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var property = context.Properties.Find(id);
            return View("PropertyDelete",property);
        }

        [HttpPost]
        public IActionResult Delete(Property property)
        {
            try
            {
                context.Properties.Remove(property);
                context.SaveChanges();
            }
            catch (Exception ex) //Catches when a change cant be made due to relationships in the database
            {
                TempData["message"] = "There are one or more relationships with Payments, Property, or ProvideService that prevent deletion.";
            }
            return RedirectToAction("PropertyList");
        }
    }
}
