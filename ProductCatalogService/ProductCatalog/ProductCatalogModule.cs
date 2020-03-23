namespace ProductCatalogService.ProductCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Nancy;

    public class ProductCatalogModule : NancyModule
    {
        private readonly IProductCatalogStore _productCatalogStore;

        public ProductCatalogModule(IProductCatalogStore productCatalogStore)
            : base("/products")
        {
            _productCatalogStore = productCatalogStore ?? throw new ArgumentNullException(nameof(productCatalogStore));
        }

        private void SetupGetProductCatalogs() =>
            Get("", async (_) =>
            {
                string productIdsQuery = this.Request.Query.productIds;
                var productIds = ParseProductIdsFromQueryString(productIdsQuery);
                var products = await _productCatalogStore.GetProductsByIds(productIds);
                return this
                    .Negotiate
                    .WithModel(products)
                    .WithHeader("cache-control", "max-age:86400");
            });

        private static IEnumerable<int> ParseProductIdsFromQueryString(string productIdsString)
        {
            return productIdsString.Split(',').Select(s => s.Replace("[", "").Replace("]", "")).Select(int.Parse);
        }
    }
}