using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class Hakkimizda : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
