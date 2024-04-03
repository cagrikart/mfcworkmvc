using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly SubCategoryService _subCategoryService;

        public SubCategoryController(SubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        public IActionResult SubControllerList()
        {
            var subCategories = _subCategoryService.GetAllSubCategories();
            return View(subCategories);
        }
        public ActionResult CreateSubCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSubCategory(SubCategory subCategory)
        {
                _subCategoryService.AddSubCategory(subCategory);
                return RedirectToAction("SubControllerList");
        }
    }
}
