using System.ComponentModel.DataAnnotations.Schema;

namespace mfcworkmvc.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        [ForeignKey("subCategoryId")]

        public int? subCategoryId { get; set; }


        public SubCategory subCategory { get; set; }    
    }
}
