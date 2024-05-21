// listas

internal static class ProgramHelpers
{
    /*    private static void primeiroMenu(string[] args)
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
        }*/

    private static void segundoMenu(string[] args)
    {
        var numerosFibonacci = new List<int> { 1, 1 };

        var visualizacao = numerosFibonacci[numerosFibonacci.Count - 1];
        var visualizacao2 = numerosFibonacci[numerosFibonacci.Count - 2];

        numerosFibonacci.Add(visualizacao + visualizacao2);

        foreach (var numeros in numerosFibonacci)
        {
            Console.WriteLine(numeros.ToString());
        }


    }
}