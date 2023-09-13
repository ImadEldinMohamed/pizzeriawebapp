using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pizzeriawebapp.ADMIN
{
    public class Ingredienti
    {
        public string Nome { get; set; }
        public double Prezzo { get; set; }

        public Ingredienti() { }    
        public Ingredienti(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo= prezzo; 
        }
    }

}