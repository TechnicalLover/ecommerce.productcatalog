using ProductCatalogService.EventFeed.Configurations;

namespace ProductCatalogService.EventFeed
{
    public class SqlEventStore : IEventStore
    {
        public SqlEventStore(EventStoreConfig config)
        {

        }
    }
}