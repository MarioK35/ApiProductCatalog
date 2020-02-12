        
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace BooksApi.Models
{
    public class DetailsProduct{

        
    
        public List<string> Artista {get;set;}

        ///cuando son albunes musicales 
        public string Titulo {get;set;}
        public List<string> Genero {get;set;}
        public List<string> Canciones {get;set;}

        //cuando son peliculas

        public List<string> Director {get;set;}
        public List<string> Escritores {get;set;}
        public List<string> Formato {get;set;}

        

    }
    
}