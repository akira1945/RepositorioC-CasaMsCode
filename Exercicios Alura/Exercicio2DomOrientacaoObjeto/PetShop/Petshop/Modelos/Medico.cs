using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Modelos
{
    public class Medico
    {
        public string Nome { get; set; }

        public string Especialidade { get; set; }

        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

    }
}