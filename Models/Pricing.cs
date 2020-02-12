using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models
{
    public class Pricing{

         [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public decimal PrecioLista {get;set;}
        public decimal PrecioProveedor {get;set;}
        

    }
    
}