using mfcworkmvc.Models;

namespace mfcworkmvc.Service
{
    public class SubCategoryService
    {
        private readonly MvcDbContext _dbContext;

        public SubCategoryService(MvcDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSubCategory(SubCategory subCategory)
        {
            _dbContext.SubCategories.Add(subCategory);
            _dbContext.SaveChanges();
        }
        public List<SubCategory> GetAllSubCategories()
        {
            return _dbContext.SubCategories.ToList();
        }
    }
}
