﻿using System.Collections.Generic;
using System.Linq;
using JasperGreenTeam02.Models;
using Microsoft.AspNetCore.Mvc;

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

            return View("CustomerAddEdit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

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

            if (ModelState.IsValid)
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
                return RedirectToAction("List");
            }
            else
            {
                return View("AddEdit", customer);
            }
        }

        [HttpGet]
        public IActionResult CustomerDelete(int id)
        {
            var product = context.Customers.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult CustomerDelete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }
    }
}