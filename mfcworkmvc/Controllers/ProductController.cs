﻿using mfcworkmvc.Models;
using mfcworkmvc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace mfcworkmvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly SubCategoryService _subCategoryService;
        private readonly MvcDbContext _dbContext;

        public ProductController(ProductService productService, SubCategoryService subCategoryService, MvcDbContext dbContext)
        {
            _productService = productService;
            _subCategoryService = subCategoryService;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
       
        public ActionResult Create()
        {
            ViewData["subCategoryId"] = new SelectList(_dbContext.SubCategories, "id", "name");
            ViewData["mainCategoryId"] = new SelectList(_dbContext.MainCategories, "id", "name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,description,subCategoryId,mainCategoryId,ImagesBase64")] Product product)
        {
            if (product.ImagesBase64 == null || product.ImagesBase64.Count == 0)
            {
                ModelState.AddModelError("ImagesBase64", "Please provide at least one image for the product.");
                return View(product);
            }

            _dbContext.Add(product);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}
