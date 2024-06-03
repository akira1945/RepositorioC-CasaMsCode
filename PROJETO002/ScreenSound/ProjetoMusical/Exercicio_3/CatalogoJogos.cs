using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_3
{
    public class CatalogoJogos

    {
        private List<Jogo> Jogos;

        public bool CatalogoVazio => Jogos.Count==0;

        public CatalogoJogos()
        {
            Jogos = new List<Jogo>();
        }
    }
}