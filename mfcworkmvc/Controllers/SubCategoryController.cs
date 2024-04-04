using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace mfcworkmvc.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly SubCategoryService _subCategoryService;
        private readonly MvcDbContext _dbContext;


        public SubCategoryController(SubCategoryService subCategoryService, MvcDbContext dbContext)
        {
            _subCategoryService = subCategoryService;
            _dbContext = dbContext;
        }
        public IActionResult SubControllerList()
        {
            var subCategories = _subCategoryService.GetAllSubCategories();
            return View(subCategories);
        }
        public ActionResult CreateSubCategory()
        {
            ViewData["mainCategoryId"] = new SelectList(_dbContext.MainCategories, "id", "name");
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
