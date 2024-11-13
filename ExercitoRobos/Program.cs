using System.Runtime.CompilerServices;

class ExercitoDeRobos
{
    public class Robo(string nome, string modelo, int anoFabricacao)
    {
        private string Nome { get; set; } = nome;
        private string Modelo { get; set; } = modelo;
        private int AnoFabricacao { get; set; } = anoFabricacao;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações: O robô {Nome}, modelo {Modelo}, foi fabricado em {AnoFabricacao}.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Robô : ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o modelo do Robô : ");
            string modelo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o ano de fabricação do Robô : ");
            int anoFabricacao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Robo newRobo = new(nome, modelo, anoFabricacao);

            newRobo.ExibirInformacoes();
        }
    }

}