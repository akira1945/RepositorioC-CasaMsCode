using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

    internal class Avaliacao

    {
        public int Nota { get; }
        
        public Avaliacao(int nota)
        {
            this.Nota = nota;
        }
    
        public static Avaliacao Parse(string texto)
        {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
        }
    }
