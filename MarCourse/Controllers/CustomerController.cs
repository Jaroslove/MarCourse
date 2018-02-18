using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarCourse.Models;
using System.Data.Entity;

namespace MarCourse.Controllers
{
    public class CustomerController : Controller
    {
        TheatreContext context;

        public CustomerController()
        {
            context = new TheatreContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = context.Customers.Include(a => a.MembershipType).ToList();

            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}