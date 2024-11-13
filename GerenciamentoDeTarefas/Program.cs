namespace GerenciamentoDeTarefas;
public class Principal
{
    public class Tarefas(string titulo, string descricao, string dataVencimento)
    {
        public string Titulo { get; set; } = titulo;
        public string Descricao { get; set; } = descricao;
        public string DataVencimento { get; set; } = dataVencimento;

        public void Tarefa()
        {
            Console.WriteLine($"Tarefa: {Titulo} / Descrição: {Descricao} / Data de Vencimento: {DataVencimento}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o título da tarefa: ");
        string titulo = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a data de vencimento da tarefa: ");
        string dataVencimento = Console.ReadLine();
        Console.WriteLine();

        Tarefas newTarefa = new(titulo, descricao, dataVencimento);

        if (descricao.Length > 50)
            Console.WriteLine("O Valor da descrição excede a quantidade de caracteres permitidos");
        else
            newTarefa.Tarefa();
    }
}