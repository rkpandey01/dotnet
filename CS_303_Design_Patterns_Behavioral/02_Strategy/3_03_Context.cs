namespace _02_Strategy
{
    // Context class that uses the strategy
    public class DataProcessor
    {
        private IDataStorageStrategy storageStrategy;

        public DataProcessor(IDataStorageStrategy strategy)
        {
            this.storageStrategy = strategy;
        }

        public void SetStorageStrategy(IDataStorageStrategy strategy)
        {
            this.storageStrategy = strategy;
        }

        public void ProcessAndStoreData(string data)
        {
            // Additional processing logic can be added here
            Console.WriteLine("Processing data...");

            // Store data using the selected strategy
            storageStrategy.StoreData(data);
        }
    }

}
