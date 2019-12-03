using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // Allows Customers to be populated using the Customers Database.
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // This allows for us to return the list of customers to the view.
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        // This is to access the customer's details.
        public ActionResult Details(int id)
        {
            // This will get the customer id which can be used in the url.
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            // If the customer id does not correspond to an existing customer user will be redirected to HttpNotFound page.
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}