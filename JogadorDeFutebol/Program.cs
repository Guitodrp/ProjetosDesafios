namespace JogadorDeFutebol;

public class Principal
{

    public class Jogador()
    {
        public string Nome { get; private set; }
        public string Nacionalidade { get; private set; }
        public int Idade { get; private set; }
        public string Posicao { get; private set; }

        public static Jogador NovoJogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Jogador novoJogador = new()
            {
                Idade = idade,
                Posicao = posicao,
                Nome = nome,
                Nacionalidade = nacionalidade,
            };
            return novoJogador;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do jogador : ");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a nacionalidade do jogador : ");
        string nacionalidade = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a idade do jogador : ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite a posição do jogador : ");
        string posicao = Console.ReadLine();
        Console.WriteLine();

        Jogador novoJogador = Jogador.NovoJogador(nome, nacionalidade, idade, posicao);

        Console.WriteLine($"Jogador criado! \r\n{nome} \r\n{nacionalidade} \r\n{idade} \r\nPosição: {posicao}");
    }
}