using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Product
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Folio { get; set; }

        [BsonElement("Titulo")]
         [JsonProperty("Titulo")]
        public string Titulo { get; set; }

        [BsonElement("Descripcion")]
        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("Precio")]
        [JsonProperty("Precio")]
        public Pricing pricing {get;set;}
        
        [BsonElement("Detalles")]
        [JsonProperty("Detalles")]
        public DetailsProduct details {get;set;}



    


    }
}
