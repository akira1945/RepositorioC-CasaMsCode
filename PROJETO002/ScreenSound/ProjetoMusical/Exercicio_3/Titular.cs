using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_3
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    
        public Titular(string nome, string cpf, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
        }
    
    }


}