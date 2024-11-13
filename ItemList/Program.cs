class ItemList
{
    static void Main(string[] args)
    {
        List<string> itemList = [];

        Console.WriteLine("Digite quantos itens deseja cadastrar");
        var nItem = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= nItem; i++)
        {
            Console.WriteLine("Digite o item para cadastro");
            itemList.Add(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Lista de itens: ");
        foreach (var item in itemList)
            Console.WriteLine($"-  {item}");
    }

}