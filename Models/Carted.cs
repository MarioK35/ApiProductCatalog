using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BooksApi.Models
{
    public class Carted


    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("IdCart")]
        [JsonProperty("IdCart")]
        public string IdCart { get; set; }

        [BsonElement("Cantidad")]
        [JsonProperty("Cantidad")]
        public string Cantidad { get; set; }

        [BsonElement("FechaUltimaModificacion")]
        [JsonProperty("FechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }


    }
    
    
    
}