namespace TesteUnitario;

public class Principal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um Id : ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite a descrição : ");
        string desc = (Console.ReadLine());
        Console.WriteLine();

        if (desc.Length > 50 || id < 0)
            Console.WriteLine("ID de teste invalido ou descricao muito longa.");
        else
            Console.WriteLine("Dados corretos.");
    }

}