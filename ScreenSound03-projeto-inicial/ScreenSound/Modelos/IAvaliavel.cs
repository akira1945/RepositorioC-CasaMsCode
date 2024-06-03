using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal interface IAvaliavel
    {
        double Media {get;}
        void AdiconarNota(Avaliacao nota);
       
    }
}