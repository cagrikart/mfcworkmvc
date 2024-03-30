using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class Blog : Controller
    {
        public IActionResult BlogPage()
        {
            return View();
        }
    }
}
