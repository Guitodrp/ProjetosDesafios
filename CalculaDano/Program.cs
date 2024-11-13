class CalculaDano
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o valor de ataque: ");
        var ataque = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Insira o valor de defesa: ");
        var defesa = int.Parse(Console.ReadLine());

        int totalDano = CalcularDano(ataque, defesa);

        Console.WriteLine($"O dano causado pelo ataque foi: {totalDano}");

    }

    public static int CalcularDano(int ataque, int defesa)
    {
        var dano = ataque - defesa;

        if (dano < 0)
            dano = 0;

        return dano;
    }
}