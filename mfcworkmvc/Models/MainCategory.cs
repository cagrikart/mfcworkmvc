namespace mfcworkmvc.Models
{
    public class MainCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
