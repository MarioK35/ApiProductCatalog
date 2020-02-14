using BooksApi.Models;
using BooksApi.Data;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace BooksApi.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _books;

        public ProductService(IStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Product>(settings.BooksCollectionName);
        }

        public List<Product> Get() =>
            _books.Find(book => true).ToList();

        public Product Get(string id) =>
            _books.Find<Product>(book => book.Folio == id).FirstOrDefault();

    
        
        public Product Create(Product book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Product bookIn) =>
            _books.ReplaceOne(book => book.Folio == id, bookIn);

        public void Remove(Product bookIn) =>
            _books.DeleteOne(book => book.Folio == bookIn.Folio);

        public void Remove(string id) => 
            _books.DeleteOne(book => book.Folio == id);
  

        
}

    }
    
