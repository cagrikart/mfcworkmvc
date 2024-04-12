using System.ComponentModel.DataAnnotations.Schema;

namespace mfcworkmvc.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> ImagesBase64 { get; set; } = new List<string>(); // Çoklu resim desteği

        [ForeignKey("subCategoryId")]
        public int? subCategoryId { get; set; }
        public SubCategory subCategory { get; set; }

        [ForeignKey("mainCategoryId")]
        public int? mainCategoryId { get; set; }
        public MainCategory mainCategory { get; set; }
    }
}
