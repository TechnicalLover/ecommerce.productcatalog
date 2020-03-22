namespace ProductCatalogService.EventFeed
{
    using ProductCatalogService.EventFeed.Models.Configurations;

    public class SqlEventStore : IEventStore
    {
        public SqlEventStore(EventStoreConfig config)
        {

        }
    }
}