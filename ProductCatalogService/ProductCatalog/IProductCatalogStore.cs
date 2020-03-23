namespace ProductCatalogService.ProductCatalog
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProductCatalogService.Models.Dto;

    public interface IProductCatalogStore
    {
        Task<IEnumerable<ProductCatalog>> GetProductsByIds(IEnumerable<int> productIds);
    }
}