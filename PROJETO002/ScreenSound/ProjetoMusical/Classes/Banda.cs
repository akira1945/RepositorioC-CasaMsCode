using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.ProjetoMusical.Classes;

namespace ScreenSound.ProjetoMusical.Classes;

    public class Banda
    {
        private List<Album> albums = new List<Album>();
        public string Nome { get;}

        public Banda(string nome)
        {
            this.Nome = nome;
        }

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da band {Nome}");

            foreach (var item in albums)
            {
                Console.Write($"Nome : {item.Nome} , duração: {item.DuracaoTotal}");
            }

        }
    }
