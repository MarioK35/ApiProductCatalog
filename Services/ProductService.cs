using BooksApi.Models;
using BooksApi.Data;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BooksApi.Services
{
    public class ProductService
    {

        private readonly IMongoCollection<Product> _product;

         public ProductService(IStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _product = database.GetCollection<Product>(settings.BooksCollectionName);
        }


        
        public List<Product> Get() =>
            _product.Find(book => true).ToList();

        public Product Get(string id) =>
            _product.Find<Product>(product => product.Folio == id).FirstOrDefault();

        public Product Create(Product product)
        {
            _product.InsertOne(product);
            return product;
        }
        public void Update(string id, Product productIn) =>
            _product.ReplaceOne(Product => Product.Folio == id, productIn);

        public void Remove(Product productIn) =>
            _product.DeleteOne(Product => Product.Folio == productIn.Folio);

        public void Remove(string id) => 
            _product.DeleteOne(Product => Product.Folio == id);
  


    }
    
}