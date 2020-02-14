using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BooksApi.Models
{
    public class Cart
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FechaUltimaModificacion")]
        [JsonProperty("FechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        [BsonElement("Estado")]
        [JsonProperty("Estado")]
        public int Estado { get; set; }

        [BsonElement("Item")]
         [JsonProperty("Item")]
        public List<Item> Items {get;set;}




    }

}