using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace mfcworkmvc.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ProductService _productService;
        private readonly SubCategoryService _subCategoryService;
        private readonly MainCategoryService _mainCategoryService;
 
        public ProductionController(ProductService productService, MainCategoryService mainCategoryService, SubCategoryService subCategoryService)
        {
            _productService = productService;
            _mainCategoryService = mainCategoryService;
            _subCategoryService = subCategoryService; 
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
    }
}
