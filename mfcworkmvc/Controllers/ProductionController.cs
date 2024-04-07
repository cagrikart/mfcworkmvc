using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mfcworkmvc.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ProductService _productService;
        private readonly SubCategoryService _subCategoryService;
        private readonly MainCategoryService _mainCategoryService;
        private readonly MvcDbContext _dbContext;
 
        public ProductionController(ProductService productService, MainCategoryService mainCategoryService, SubCategoryService subCategoryService, MvcDbContext dbContext)
        {
            _productService = productService;
            _mainCategoryService = mainCategoryService;
            _subCategoryService = subCategoryService;
            _dbContext = dbContext;

        }
        public IActionResult ProductionPage()
        {
            var viewModel = new AllModel
            {
                Products = _productService.GetAllProducts(),
                MainCategories = _mainCategoryService.GetAllMainCategories(),
                SubCategories = _subCategoryService.GetAllSubCategories()
                
            };

            return View(viewModel);
        }
        public IActionResult Project()
        {
            var viewModel = new AllModel
            {
                Products = _productService.GetAllProducts(),
                MainCategories = _mainCategoryService.GetAllMainCategories(),
                SubCategories = _subCategoryService.GetAllSubCategories()

            }; 
            return PartialView(viewModel);
        }
        public ActionResult ProductDetail(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.id == id);

            if (product == null)
            {
                return null; ;
            }

            return View(product);
        }
    }
}
