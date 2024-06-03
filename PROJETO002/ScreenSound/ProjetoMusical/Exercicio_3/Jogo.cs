using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_3
{
    public class Jogo
    {
        public string NomeJogo { get; set; }

        public string Genero { get; set; }

        public int AnoLancamento { get; set; }

        public Jogo(string nome, string genero, int ano)
        {
         this.NomeJogo = nome;
         this.Genero = genero;
         this.AnoLancamento = ano;   
        }
    }
}