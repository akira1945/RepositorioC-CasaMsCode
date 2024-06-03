using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Modelos
{
    public class Consulta
    {
        public Pet Animal { get; set; }

        public Dono DonoAnimal { get; set; }

        public Medico Veterinario { get; set; }

        public DateTime DataDaConsulta { get; set; }

        public Consulta(Pet animal, Dono donoAnimal, Medico veterinario, DateTime dataDaConsulta)
        {
            Animal = animal;
            DonoAnimal = donoAnimal;
            Veterinario = veterinario;
            DataDaConsulta = dataDaConsulta;
        }
    }
}