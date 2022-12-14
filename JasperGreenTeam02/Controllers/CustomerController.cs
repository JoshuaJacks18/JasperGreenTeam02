//AUTHOR:   Joshua Jacks, Justin Jiang 
//COURSE:   ISTM 415 Section 501
//FORM:  CustomerController.cs 
//PURPOSE:  This controller links the customer data from the
//database with the views for customers.
//INITIALIZE: This class is initiated when any data from the
//customer is needed or if there is an action from the model ran.
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
    public class CustomerController : Controller
    {
        private JasperGreenContext context { get; set; }

        public CustomerController(JasperGreenContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult CustomerList()
        {
            List<Customer> customers = context.Customers.OrderBy(c => c.Name).ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.States = states;

            return View("CustomerAddEdit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.States = states;

            var customer = context.Customers.Find(id);
            return View("CustomerAddEdit", customer);
        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            if (customer.CustomerID == 0)
            {
                ViewBag.Action = "Add";
            }
            else
            {
                ViewBag.Action = "Edit";
            }

            if (ModelState.IsValid) //checking validation
            {
                if (ViewBag.Action == "Add")
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("CustomerList"); //Successful changes were made
            }
            else
            {
                ViewBag.States = states;
                return View("AddEdit", customer); //There was a validation error and is sent back to the edit page
            }
        }

        [HttpGet]
        public IActionResult CustomerDelete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult CustomerDelete(Customer customer)
        {
            try
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            catch (Exception ex) //Catches when a change cant be made due to relationships in the database
            {
                TempData["message"] = "There are one or more relationships with Payments, Property, or ProvideService that prevent deletion.";
            }
            return RedirectToAction("CustomerList");
        }

        public List<string> states = new List<string>()
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY",
            "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI",
            "SC", "SC", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
        };
    }
}
