class ItemMagico
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do item");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a descricao do item");
        string descricao = Console.ReadLine();
        Console.WriteLine();
        
        Console.WriteLine("Digite o nome do item");
        int poder = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine(CriarItem(nome, descricao, poder)); 
    }

    static string CriarItem(string nome, string descricao, int poder)
    {
        return ($" Item: \r\n Nome: {nome} \r\n Descrição: {descricao} \r\n Poder: {poder}");
    }

}