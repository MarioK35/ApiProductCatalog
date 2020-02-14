using BooksApi.Models;
using BooksApi.Data;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BooksApi.Services
{
    public class CartService
    {


          private readonly IMongoCollection<Cart> _books;

        
         public CartService(IStoreDatabaseSettingsCart settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Cart>(settings.BooksCollectionName);
        }

        public List<Cart> Get() =>
            _books.Find(book => true).ToList();

        public Cart Get(string id) =>
            _books.Find<Cart>(book => book.Id == id).FirstOrDefault();

    
        
        public Cart Create(Cart cart)
        {
            _books.InsertOne(cart);
            return cart;
        }

        public void Update(string id, Cart cartIn) =>
            _books.ReplaceOne(book => book.Id == id, cartIn);

        public void Remove(Cart cartIn) =>
            _books.DeleteOne(cart => cart.Id == cartIn.Id);

        public void Remove(string id) => 
            _books.DeleteOne(cart => cart.Id == id);
  


    }
    
}