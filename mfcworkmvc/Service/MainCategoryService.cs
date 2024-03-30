using mfcworkmvc.Models;

namespace mfcworkmvc.Service
{
    public class MainCategoryService
    {
        private readonly MvcDbContext _dbContext;

        public MainCategoryService(MvcDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddMainCategory(MainCategory mainCategory)
        {
            _dbContext.MainCategories.Add(mainCategory);
            _dbContext.SaveChanges();
        }
        public List<MainCategory> GetAllMainCategories()
        {
            return _dbContext.MainCategories.ToList();
        }
    }
}
