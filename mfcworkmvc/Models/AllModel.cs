namespace mfcworkmvc.Models
{
    public class AllModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SubCategory> SubCategories{ get; set; }
        public IEnumerable<MainCategory> MainCategories { get; set; }
    }
}
