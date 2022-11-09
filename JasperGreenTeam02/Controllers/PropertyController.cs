using JasperGreenTeam02.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

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
            if (ModelState.IsValid)
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
                return RedirectToAction("PropertyList");
            }
            else
            {
                if (property.PropertyID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View(property);
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
            context.Properties.Remove(property);
            context.SaveChanges();
            return RedirectToAction("PropertyList");
        }
    }
}
