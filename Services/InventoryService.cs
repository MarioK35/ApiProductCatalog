using BooksApi.Models;
using BooksApi.Data;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace BooksApi.Services
{
    public class InventoryService
    {

         private readonly IMongoCollection<Inventory> _books;

        
         public InventoryService(IStoreDatabaseSettingsInventory settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Inventory>(settings.BooksCollectionName);
        }

        public List<Inventory> Get() =>
            _books.Find(book => true).ToList();

        public Inventory Get(string id) =>
            _books.Find<Inventory>(book => book.Id == id).FirstOrDefault();

    
        
        public Inventory Create(Inventory book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Inventory bookIn) =>
            _books.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Inventory bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) => 
            _books.DeleteOne(book => book.Id == id);
  

        






    }
}