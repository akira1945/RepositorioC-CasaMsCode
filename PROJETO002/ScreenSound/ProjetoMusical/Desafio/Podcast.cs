using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Desafio
{
    public class Podcast
    {
 
        private List<Episodio> Episodios = new List<Episodio>();
        public string Nome { get; }    

        public string Host { get; }

        public int TotalEpisodios  => Episodios.Count;

       public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            Episodios.Add(episodio);
        }

        public void ExibirDetalhesPodcast()
        {
            System.Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
            foreach (var item in Episodios.OrderBy(e => e.Ordem))
            {
             Console.WriteLine(item.Resumo);
            }
            Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
        }
        
    }
}