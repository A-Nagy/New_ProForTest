namespace New_ProForTest
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string? SupplierContact { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierAddress { get; set; }
        public DateTime? CreatedAt { get; set; }=DateTime.Now;
        public ICollection<Product>? Products { get; set; }

    }
}
