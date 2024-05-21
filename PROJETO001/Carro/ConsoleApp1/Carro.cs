using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro // Classe
    {
        public string Modelo { get; set; }

        public string Cor { get; set; }

        public int Ano { get; set; }

        public string Placa { get; set; }

        public decimal VelocidadeAtual { get; set; }


        public Carro(string modelo, string cor, int ano, string placa, decimal velocidadeAtual) // Construtores
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Placa = placa;
            VelocidadeAtual = velocidadeAtual;
            
        }

        public Carro()
        {
            
        }

        public void Acelerar(int incremento) // Metodo
        {
           VelocidadeAtual += incremento;
            Console.WriteLine($"Acelerando: Velocidade atual {VelocidadeAtual} km/h");
        }

        public void Frear(int decremento) 
        {
            if (VelocidadeAtual > 0 && decremento < VelocidadeAtual)
                Console.WriteLine($"Reduzindo a velocidade para {VelocidadeAtual}");
            else
                Console.WriteLine("Operação invalida: Carro já esta parado ou Decremento é maior que a velocidade atual");
        }

        public void Virar(string direcao)
        {
            Console.WriteLine($"Carro virando para a {direcao}");
        }

    }
}
