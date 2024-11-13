namespace PessoaPOO;

public class Principal
{
    public class Pessoa(string nome, int idade)
    {
        private string Nome { get; set; } = nome;
        private int Idade { get; set; } = idade;

        public string GetNome() => nome;
        public int GetIdade() => idade;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Pessoa newPessoa = new(nome, idade);
        Console.WriteLine($"Nome: {newPessoa.GetNome()}, Idade: {newPessoa.GetIdade()}.");
    }
}