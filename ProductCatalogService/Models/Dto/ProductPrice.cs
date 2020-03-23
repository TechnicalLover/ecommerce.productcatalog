namespace ProductCatalogService.Models.Dto
{
    public class ProductPrice
    {
        public int Id { get; set; }

        public string PriceName { get; set; }

        public int PriceGroupCode { get; set; }

        public string PriceGroupName { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }
    }
}