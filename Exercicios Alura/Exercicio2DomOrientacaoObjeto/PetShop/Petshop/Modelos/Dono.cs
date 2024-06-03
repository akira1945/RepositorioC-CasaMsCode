using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Modelos
{
    public class Dono
    {
        public string Nome { get; set; }

        public string  Contato { get; set; }

        public Dono(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

    }
}