namespace mfcworkmvc.Service
{
    using mfcworkmvc.Models;
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
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
    }

}
