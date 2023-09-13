using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pizzeriawebapp.ADMIN
{
    public class Pizza
    {
        public string Nome { get; set; }
        public double Prezzo  { get; set; }
         public static List<Ingredienti> listaingrediente = new List<Ingredienti>(); 
        
        public Pizza() { }  
        public Pizza(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}