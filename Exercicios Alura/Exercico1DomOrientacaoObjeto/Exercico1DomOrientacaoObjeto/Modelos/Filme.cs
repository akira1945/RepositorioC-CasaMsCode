using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.Modelos
{
    internal class Filme
    {
        public string Titulo { get; set; }

        public int Duracao { get; set; }

        public List<string> Elenco { get; set; }

        public Filme(string titulo, int duracao, List<string> elenco)
        {
            this.Titulo = titulo;
            this.Duracao = duracao;
            if(elenco == null ) 
            {
                Elenco = new List<string>();
            }
            else 
            {
                Elenco = elenco;
            }
        }

        public void AdicionarElenco(string ator) 
        { 
            Elenco.Add(ator);
            Console.WriteLine($"{ator} faz parte do elenco do Filme: {Titulo}");    
        }

        public void ListarElenco() 
        { 
            if(Elenco.Count == 0) 
            {
                Console.WriteLine("Elenco não informado!");
            }
            else 
            {
                Console.Write("Elenco:");
                foreach (var item in Elenco)
                {
                    Console.Write($"{item} ," );
                                    }
            }
            
        }


    }
}
