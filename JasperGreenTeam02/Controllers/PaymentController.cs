using System.Collections.Generic;
using System;
using System.Linq;
using JasperGreenTeam02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SportsPro.Controllers
{
    public class PaymentController : Controller
    {
        private JasperGreenContext context { get; set; }

        public PaymentController(JasperGreenContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult PaymentList()
        {
            List<Payment> payment = context.Payments
                .Include(p => p.Customer)
                .OrderBy(p => p.PaymentDate)
                .ToList();
            return View(payment);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Payment = context.Payments.ToList();

            return View("PaymentAddEdit", new Payment());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Payment = context.Payments.ToList();
            var payment = context.Payments.Find(id);
            return View("PaymentAddEdit", payment);
        }

        [HttpPost]
        public IActionResult Save(Payment payment)
        {
            if (payment.PaymentID == 0)
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
                    context.Payments.Add(payment);
                }
                else
                {
                    context.Payments.Update(payment);
                }
                context.SaveChanges();
                return RedirectToAction("PaymentList");
            }
            else
            {
                return View("PaymentAddEdit", payment);
            }
        }

        [HttpGet]
        public IActionResult PaymentDelete(int id)
        {
            var payment = context.Payments.Find(id);
            return View(payment);
        }

        [HttpPost]
        public IActionResult PaymentDelete(Payment payment)
        {
            try
            {
                context.Payments.Remove(payment);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                TempData["message"] = "There are one or more relationships with Customer or ProvideService that prevent deletion.";
            }
            return RedirectToAction("PaymentList");
        }
    }
}
