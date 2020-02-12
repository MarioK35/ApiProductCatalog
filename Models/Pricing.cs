using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models
{
    public class Pricing{

        
        public string PrecioLista {get;set;}
        public string PrecioProveedor {get;set;}
        

    }
    
}