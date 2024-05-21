// listas

internal class Program
{
    private static readonly int visualizacao3;
    private static int visualizacao4;

    private static void Main(string[] args)
    {
            List<string> nomes = ["<nomes>", "Giovanna", "Daniel"];
            Console.WriteLine();
            nomes.Add("Valmira");
            nomes.Add("Sandra");
            //nomes.Remove("Daniel");
            nomes.Add("Pietra");
            nomes.Add("Laura");
            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome.ToUpper()}!");
                Console.WriteLine($"Meu nome é {nomes[1]} !");
                Console.WriteLine($"Adicionei os nomes de {nomes[5]} e {nomes[4]} !");
                Console.WriteLine($"A lista contem {nomes.Count} pessoas que amo!");
            };

            var indice = nomes.IndexOf("Claudio");
            if (indice != -1)
            {
                Console.WriteLine($"O nome {nomes[indice]} esta no indice {indice}.");
            }
            else
            {
                var indiceNaoEncontrado = nomes.IndexOf("Não encontrado");
                Console.WriteLine($"O item não foi encontrado, comando IndexOf retornou {indiceNaoEncontrado}.");
            }

            //Lista com a classe int.
            var numerosFibonacci = new List<int> { 1, 1 };
                Console.WriteLine("Nova Lista com classe Int.");

            var visualizacao = numerosFibonacci[numerosFibonacci.Count - 1];
            var visualizacao2 = numerosFibonacci[numerosFibonacci.Count - 2];

            numerosFibonacci.Add(visualizacao + visualizacao2);

            foreach (var numeros in numerosFibonacci)
            {
                Console.WriteLine(numeros.ToString());
            };

        //Exercicio

        Console.WriteLine("Exercicio :");

        var numerosFibonacciPositivos = new List<int> { 1, 1 };

        while (numerosFibonacciPositivos.Count < 20)
        {
            var visualizacao3 = numerosFibonacciPositivos[numerosFibonacciPositivos.Count - 1];
            var visualizacao4 = numerosFibonacciPositivos[numerosFibonacciPositivos.Count - 2];

            numerosFibonacciPositivos.Add(visualizacao3 + visualizacao4);
        }        
        foreach (var numeros in numerosFibonacciPositivos)
        {
            Console.WriteLine(numeros.ToString());
        };


    }

        


 }