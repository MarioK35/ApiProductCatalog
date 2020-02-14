using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Inventory
    {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("IdProduct")]
        [JsonProperty("IdProduct")]
        public string IdProduct { get; set; }

        [BsonElement("Cantidad")]
        [JsonProperty("Cantidad")]
        public string Cantidad { get; set; }
        
         [BsonElement("Carrito")]
        [JsonProperty("Carrito")]
        public List<Carted> EnCarrito { get; set; }



        


    }
}