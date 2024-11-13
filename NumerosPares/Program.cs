namespace NumerosPares;

public class Principal {

    static void Main(string[] args)
    {
        int limiteInferior, limiteSuperior, somaPares = 0;

        Console.WriteLine("Digite o numero menor: ");
        limiteInferior = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite o numero maior: ");
        limiteSuperior = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int x = limiteInferior; x <= limiteSuperior; x++)
        {

            if (x % 2 == 0)
                somaPares = somaPares + x;
        }

        Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }

}