using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class MainCategoryController : Controller
    {
        private readonly MainCategoryService _mainCategoryService;

        public MainCategoryController(MainCategoryService mainCategoryService)
        {
            _mainCategoryService = mainCategoryService;
        }
        public IActionResult Index()
        {
            var mainCategory = _mainCategoryService.GetAllMainCategories();
            return View(mainCategory);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MainCategory mainCategory)
        {
            if (ModelState.IsValid)
            {
                _mainCategoryService.AddMainCategory(mainCategory);
                return RedirectToAction("Index");
            }
            return View(mainCategory);
        }
    }
}

