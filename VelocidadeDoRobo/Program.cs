namespace VelocidadeDoRobo;

public class Principal
{
    public class Robo(int vMax, int vMin)
    {
        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMax { get; } = vMax;
        public int VelocidadeMin { get; } = vMin;

        public void Acelerar()
        {
            if (VelocidadeAtual + 1 <= vMax)
                VelocidadeAtual++;
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual - 1 >= vMin)
                VelocidadeAtual--;
        }

    }
    public static void Main(string[] args)
    {
        int vMin, vMax;

        do
        {
            Console.WriteLine("Digite a velocidade mínima e a máxima: ");
            vMin = int.Parse(Console.ReadLine());
            vMax = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        while (vMin <= 0 || vMin > vMax || vMax > 100);

        Console.WriteLine("Digite a sequencia de comandos desejada para acelerar 'A', e para desacelerar 'D' em até 100 caracteres:");
        string comandos = Console.ReadLine();

        Robo newRobo = new(vMax, vMin);

        foreach (char caracter in comandos)
        {
            if (caracter == 'A')
                newRobo.Acelerar();
            if (caracter == 'D')
                newRobo.Desacelerar();
        }

        Console.WriteLine("Velocidade atual " + newRobo.VelocidadeAtual);
    }
}