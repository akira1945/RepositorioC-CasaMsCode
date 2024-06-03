using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Desafio
{
    public class Episodio
    {
        private List<string> Convidados = new List<string>();
        public int Ordem { get; }

        public string Titulo { get; }

        public int Duracao { get; }

        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

        public Episodio(int ordem, string titulo, int duracao)
        {
            this.Ordem = ordem;
            this.Titulo = titulo;
            this.Duracao = duracao;
        }

        public void AdicionarConvidado(string convidado)
        {
            Convidados.Add(convidado);
        }



    }
}