namespace mfcworkmvc.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageBase64 { get; set; }

        // Foreign key to Product
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
