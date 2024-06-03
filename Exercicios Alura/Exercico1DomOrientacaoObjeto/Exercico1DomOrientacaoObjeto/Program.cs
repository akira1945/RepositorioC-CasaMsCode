using Alura.Filmes.Modelos;

namespace Alura.Filmes.Modelos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme sony = new Filme("Dia Depois de Amanhã", 500, new List<string> { "Edgar Northon", "Renesa weeger", "Reinaldo Janequine" });
            Filme warner = new Filme("Resgate do Soldado Ryan", 1000, new List<string> { "Vin Disel", "Sidney Potier", "Lawrence Phishburg" });
            Filme paris = new Filme("Assalto ao trem pagador", 340, new List<string> { "Jean Renault", "Jim Cavisel", "Zeca Baleiro" });
            Filme globo = new Filme("Navalha na carne", 220, new List<string> { "Marisa Tome", "Julia Roberts", "Suzana Verne" });
            Filme sbt = new Filme("A praça pede passagem", 300, new List<string> { "Carlos Alberto", "Paulinho Gogo", "Tiringa" });


            List<Filme> meusFilmes = new List<Filme>();
            meusFilmes.Add(sony);
            meusFilmes.Add(warner);
            meusFilmes.Add(paris);
            meusFilmes.Add((globo));
            meusFilmes.Add(sbt);

            foreach (Filme item in meusFilmes)
            {
                Console.WriteLine($"Filme: {item.Titulo}");
                Console.WriteLine($"Duração: {item.Duracao}");
                item.ListarElenco();
                Console.WriteLine();
                
                
            }

        }


    }
}
