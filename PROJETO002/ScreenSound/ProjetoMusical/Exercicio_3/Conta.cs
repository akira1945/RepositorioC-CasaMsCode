using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_3
{
    public class Conta
    {
    public Titular Titular {get; set;}
    public int Agencia {get; set;}
    public int NumeroDaConta {get; set;}
    public double Saldo {get;}
    public double Limite {get; set;}

    public Conta(Titular titular, int agencia, int numeroDaConta,double saldo, double limite)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.Saldo = 0;
        this.Limite = limite;
    }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
    }
}