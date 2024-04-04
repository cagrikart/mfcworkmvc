using System.ComponentModel.DataAnnotations.Schema;

namespace mfcworkmvc.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Product> Products { get; set; }

        [ForeignKey("mainCategoryId")]
        public int? mainCategoryId { get; set; }
        public MainCategory mainCategory { get; set; }

    }
}
