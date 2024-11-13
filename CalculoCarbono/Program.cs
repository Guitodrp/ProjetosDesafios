namespace CalculoCarbono;

public class Principal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a quantidade de KM por dia: ");
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite a quantidade de horas de eletronico por dia: ");
        int horasDeEletronico = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite a quantidade de refeições com carne: ");
        int refeicoesComCarne = int.Parse(Console.ReadLine());
        Console.WriteLine();

        double resultado = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronico, refeicoesComCarne);
        Console.WriteLine($"{nome}, sua pegada de carbono é de {resultado} toneladas de CO2 por ano.");
    }

    private static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronico, int refeicoesComCarne)
        => quilometrosPorDia * 365 * 0.2 + horasDeEletronico * 0.1 + refeicoesComCarne * 0.5;

}