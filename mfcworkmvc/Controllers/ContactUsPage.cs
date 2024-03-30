using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class ContactUsPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
