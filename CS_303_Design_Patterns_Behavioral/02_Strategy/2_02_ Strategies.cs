namespace _02_Strategy
{
    // Concrete strategy 1: Store data in a fast, in-memory cache
    public class InMemoryStorageStrategy : IDataStorageStrategy
    {
        public void StoreData(string data)
        {
            Console.WriteLine("Storing data in memory: " + data);
        }
    }

    // Concrete strategy 2: Store data in a reliable, persistent database
    public class DatabaseStorageStrategy : IDataStorageStrategy
    {
        public void StoreData(string data)
        {
            Console.WriteLine("Storing data in the database: " + data);
        }
    }

    // Concrete strategy 3: Store data in a cost-effective, cloud-based storage
    public class CloudStorageStrategy : IDataStorageStrategy
    {
        public void StoreData(string data)
        {
            Console.WriteLine("Storing data in the cloud: " + data);
        }
    }

}
