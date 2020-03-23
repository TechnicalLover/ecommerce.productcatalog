namespace ProductCatalogService.EventFeed
{
    using ProductCatalogService.Models.Configurations;

    public class SqlEventStore : IEventStore
    {
        public SqlEventStore(EventStoreConfig config)
        {

        }
    }
}