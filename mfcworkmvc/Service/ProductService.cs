namespace mfcworkmvc.Service
{
    using mfcworkmvc.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductService
    {
        private readonly MvcDbContext _dbContext;

        public ProductService(MvcDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            var subCategory = _dbContext.SubCategories.FirstOrDefault(s => s.id == product.subCategory.id);
            var mainCategory = _dbContext.MainCategories.FirstOrDefault(s => s.id == product.mainCategory.id);

         
                product.subCategory = subCategory;
                product.mainCategory = mainCategory;

                _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }       

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.Include(p => p.subCategory).Include(p=>p.mainCategory).ToList();
        }
    }

}
