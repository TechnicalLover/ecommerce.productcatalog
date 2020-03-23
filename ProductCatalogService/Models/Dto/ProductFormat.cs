namespace ProductCatalogService.Models.Dto
{
    using System.Linq;

    public class ProductFormat
    {
        public int Id { get; set; }

        public string FormatName { get; set; }

        public ProductUnit Unit { get; set; }

        public ProductPrice[] Prices { get; set; }

        public ProductPrice GetRetailerPrice()
        {
            return Prices.First(p => p.PriceGroupCode == 1);
        }
    }
}