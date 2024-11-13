namespace ElementoMajoritario;

public class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite o tamanho da lista : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o elemento {i} do array: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(
            );
        Console.WriteLine("O elemento que mais se repete é : " + Majoritario(array));
    }

    public static int Majoritario(int[] array)
    {

        int major = array[0];
        int count = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (major != array[i])
            {
                major = array[i];
                count = 1;
            }
            else
            {
                if (major == array[i])
                    count++;
                else
                    count--;
            }
        }
        return major;

    }
}