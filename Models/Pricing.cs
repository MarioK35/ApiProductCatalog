using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Pricing{

        [BsonElement("PrecioLista")]
        [JsonProperty("PrecioLista")]
        public string PrecioLista {get;set;}

        [BsonElement("PrecioProveedor")]
        [JsonProperty("PrecioProveedor")]
        public string PrecioProveedor {get;set;}
        

    }
    
}