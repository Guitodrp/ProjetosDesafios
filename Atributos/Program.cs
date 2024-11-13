using System.ComponentModel.DataAnnotations;

class Atributos
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do atributo: ");
        string nomeAtributo = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite o valor minimo do atributo: ");
        int valorMinimo = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite o valor maximo do atributo: ");
        int valorMaximo = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool validaAtributo = VerificaAtributo(nomeAtributo, valorMinimo, valorMaximo);

        if (validaAtributo)
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");

        else
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
    }
    static bool VerificaAtributo(string nomeAtributo, int valorMinimo, int valorMaximo)
    {
        Console.WriteLine($"Digite o valor do atributo {nomeAtributo}");
        int valorAtributo = int.Parse(Console.ReadLine());

        if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo)
            return true;
        else
            return false;
    }
}