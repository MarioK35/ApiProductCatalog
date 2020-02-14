using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BooksApi.Models
{
    public class Item
    {

        
        [BsonElement("IdProducto")]
        [JsonProperty("IdProducto")]
         public string IdProduct { get; set; }

        [BsonElement("CantidadItem")]
        [JsonProperty("CantidadItem")]
        public string Cantidad { get; set; }
        





    }
}