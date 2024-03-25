using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult ProductionPage()
        {
            return View();
        }
    }
}
