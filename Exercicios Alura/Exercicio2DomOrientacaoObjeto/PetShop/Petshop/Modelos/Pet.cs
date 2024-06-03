using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Modelos
{
    public class Pet
    {   
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Especie { get; set; }

        public Pet(string nome, int idade, string especie)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }
   
    }

}