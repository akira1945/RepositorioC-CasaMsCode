using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMusical.Classes;

namespace ScreenSound.ProjetoMusical.Classes;

    public class Musica
    {
        public string NomeMusica { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        private bool Disponivel;
        public string DescricaoResumida => $"Esta musica pertence a banda {Artista.Nome} sua duração esta convertida para segundos: {Duracao}";
        public Genero Genero { get; set; }
        // { 
        //     get
        //     {
        //         return $"Esta musica pertence a banda {Artista} sua duração esta convertida para segundos: {Duracao}";
        //     } 
        // }

        public bool disponivel { get { return Disponivel; } set { Disponivel = value; } }

        public Musica(string nome, Banda artista, int duracao, bool disponivel)
        {
            NomeMusica = nome;
            Artista = artista;
            Duracao = duracao;
            this.Disponivel = disponivel;


        }

        // get e set em forma de metodo.
        // public void EscreverDisponivel(bool value)
        // {
        //     disponivel = value;
        // }

        // public bool LeDisponivel()
        // {
        //     return disponivel;
        // }

        public void ExibirFicaTecnica()
        {
            Console.WriteLine($"Nome: {NomeMusica}");
            System.Console.WriteLine($"Artista {Artista.Nome}");
            System.Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano+");
            }
        }

        public void ExibirNmArtMusica()
        {
            Console.WriteLine($"Nome da musica: {NomeMusica} / Artista: {Artista.Nome}");
        }

    }
