using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.Modelos
{
    internal class Artista
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public  List<Filme> FilmesAtor { get; set; }
        public int FilmesAtuados => FilmesAtor.Count;

        public Artista(string nome, int idade, List<Filme> filmesAtor)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtor = new List<Filme>();
                    
        }

        public void AdicionarFilmesAtor(Filme filme)
        {
            FilmesAtor.Add(filme);
        }

        public void ListarFilmesAtor() 
        {
            if (this.FilmesAtor.Count == 0)
            {
                Console.WriteLine($"Não existe filmes na lista com ator: {Nome}");
            }
            else 
            {
                Console.WriteLine($"Filmes gravados pelo ator {Nome}");
                foreach (var item in FilmesAtor)
                {
                    Console.WriteLine($"Filmes : {item.Titulo}");
                }
                Console.WriteLine($"*******************************");
            }
        }


    }
}
