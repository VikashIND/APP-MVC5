using MVC5_APP.Models;
using MVC5_APP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_APP.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();

            var viewModel = new CustomerViewModel()
            {
                membershipTypes = membershipType
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(CustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerViewModel()
                {
                    Customer = model.Customer,
                    membershipTypes = _context.MembershipTypes.ToList()
                };
                return View("New", viewModel);

            }
            _context.Customers.Add(model.Customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
    }
}