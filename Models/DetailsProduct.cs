        
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class DetailsProduct{

        
        [BsonElement("Artista")]
        [JsonProperty("Artista")]
        public List<string> Artista {get;set;}

        ///cuando son albunes musicales 
        [BsonElement("Titulo")]
        [JsonProperty("Titulo")]
        public string Titulo {get;set;}

        [BsonElement("Genero")]
        [JsonProperty("Genero")]
        public List<string> Genero {get;set;}

        [BsonElement("Canciones")]
        [JsonProperty("Canciones")]
        public List<string> Canciones {get;set;}

        //cuando son peliculas
        [BsonElement("Director")]
        [JsonProperty("Director")]
        public List<string> Director {get;set;}

        [BsonElement("Escritor")]
        [JsonProperty("Escritor")]
        public List<string> Escritor {get;set;}

        [BsonElement("Formato")]
        [JsonProperty("Formato")]
        public string Formato {get;set;}

        

    }
    
}