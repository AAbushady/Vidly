using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // This allows for us to return the list of customers to the view.
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // This is to access the customer's details.
        public ActionResult Details(int id)
        {
            // This will get the customer id which can be used in the url.
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            // If the customer id does not correspond to an existing customer user will be redirected to HttpNotFound page.
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            // Customers are hardcoded, Entity Frameworks will be used later.
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Tony Redgrave" },
                new Customer { Id = 2, Name = "Cal Kestis" }
            };
        }
    }
}