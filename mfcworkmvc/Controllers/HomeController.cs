using mfcworkmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mfcworkmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var list = new List<Customer>();

            var customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Customer One";
            customer1.Description = "Customer One Description";

            var customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Customer Two";
            customer2.Description = "Customer Two Description";

            var customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Customer Three";
            customer3.Description = "Customer Three Description";

            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);

            return View(list);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}