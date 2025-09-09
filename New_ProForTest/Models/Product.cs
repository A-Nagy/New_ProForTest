using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace New_ProForTest
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
     
        public string? ProductDescription { get; set; }=null;   

        public double? ProductPrice { get; set; }=0;
        public int? ProductQTY { get; set; }=0; 
        public int CategotyId { get; set; }
      

        [ForeignKey("CategotyId")]        
        public Categoty? Categoty { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string? ImageName { get; set; }=null;



    }
}
