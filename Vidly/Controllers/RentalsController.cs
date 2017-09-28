using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        public ActionResult New()
        {
            var rental = new Rental();

            return View("RentalForm", rental);
        }

        public ActionResult Save()
        {
            return RedirectToAction("New", "Rentals");
        }
    }
}