using System.Net.WebSockets;

namespace CatalogoDeJogos;

public class Principal {
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de jogos a serem adicionados : ");
        int quantidadeJogos = int.Parse(Console.ReadLine());
        Console.WriteLine();

        List<string> nomesJogos = [];

        for (int i = 1; i <= quantidadeJogos; i++)
        {
            Console.WriteLine($"Digite o nome do {i} jogo: ");
            nomesJogos.Add(Console.ReadLine());
            Console.WriteLine();
        }

        string resultado = string.Join(", ", nomesJogos);
        Console.WriteLine($"Foram adicionados {quantidadeJogos} jogos : {resultado} ");
    }
}