namespace mfcworkmvc.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public string name { get; set; }

        public MainCategory mainCategory { get; set; } 
    }
}
