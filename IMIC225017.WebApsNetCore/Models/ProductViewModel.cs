namespace IMIC225017.WebApsNetCore.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int? ProductStatus { get; set; }
        public int? CatorgoryId { get; set; }
        public string CatorgoryName { get; set; }
    }
}
