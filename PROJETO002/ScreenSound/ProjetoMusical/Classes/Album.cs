using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Classes
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();
       
        public string Nome { get; set; }

        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

     

    public Album()
    {
        
    }

        public void AdicionarMusica (Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (var itemMusica in musicas)
            {
                Console.WriteLine($"Nome da Muisca: {itemMusica.NomeMusica}");
            }
            Console.WriteLine($"Para ouvir esse album inteiro você precisa de {DuracaoTotal} segundos!!!!");
        }


    }
}