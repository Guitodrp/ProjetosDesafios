namespace CriandoPersonagem;

public class Principal
{

    public class Personagem(string nome, string raca, string classe)
    {
        public string Nome { get; set; } = nome;
        public string Raca { get; set; } = raca;
        public string Classe { get; set; } = classe;
        public int Nivel { get; set; } = 1;
        public int Vida { get; set; } = 10;
        public int Mana { get; set; } = 7;

        public void ExibirStatus() 
            => Console.WriteLine($"Status: \r\n Nome:{Nome}\r\n Raça:{Raca}\r\n Classe:{Classe}\r\n Nivel:{Nivel}\r\n Vida:{Vida}\r\n Mana:{Mana}");
    }
    static void Main()
    {
        Console.WriteLine("Digite o nome :");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a raça :");
        string raca = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a classe:");
        string classe = Console.ReadLine();
        Console.WriteLine();

        Personagem novoPersonagem = new(nome, raca, classe);
        novoPersonagem.ExibirStatus();
    }
}