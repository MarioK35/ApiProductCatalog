namespace BooksApi.Data
{
    public class StoreDatabaseSettingsInventory : IStoreDatabaseSettingsInventory
    {

        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IStoreDatabaseSettingsInventory
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }


}