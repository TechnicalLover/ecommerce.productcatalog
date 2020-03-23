namespace ProductCatalogService.Models.Dto
{
    public class ProductCatalog
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int DivisionCode { get; set; }

        public string DivisionName { get; set; }

        public int CategoryCode { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public ProductFormat CaseFormat { get; set; }

        public ProductFormat BundleFormat { get; set; }

        public ProductFormat UpcFormat { get; set; }
    }
}