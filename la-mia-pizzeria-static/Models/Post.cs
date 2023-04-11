﻿namespace la_mia_pizzeria_static.Models
{
    public class Post
    {
        public Post()
        {
        }
        public Post(int id, string nomePizza, string immagine, string ingredienti, decimal prezzo)
        {
            Id = id;
            NomePizza = nomePizza;
            Immagine = immagine;
            Ingredienti = ingredienti;
            Prezzo = prezzo; 
        }

        public int Id { get; set; }
        public string NomePizza { get; set; }
        public string Immagine { get; set; }
        public string Ingredienti { get; set; }
        public decimal Prezzo { get; set; }
        
    }
}
