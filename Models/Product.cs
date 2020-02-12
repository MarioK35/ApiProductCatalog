using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models
{
    public class Product
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Folio { get; set; }

        [BsonElement("Titulo")]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Pricing pricing {get;set;}
        public DetailsProduct details {get;set;}



    


    }
}
