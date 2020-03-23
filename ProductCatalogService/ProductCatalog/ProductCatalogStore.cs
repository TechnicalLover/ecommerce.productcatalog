namespace ProductCatalogService.ProductCatalog
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ProductCatalogService.Models.Configurations;
    using ProductCatalogService.Models.Dto;

    public class ProductCatalogStore : IProductCatalogStore
    {
        public ProductCatalogStore(ProductCatalogStoreConfig config)
        {

        }

        public async Task<IEnumerable<ProductCatalog>> GetProductsByIds(IEnumerable<int> productIds)
        {
            var products = productIds.Select(id =>
                new ProductCatalog());

            return await Task.FromResult(products);
        }
    }
}