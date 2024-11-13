namespace NotasAlunos;

public class Principal
{
    static void Main()
    {
        string[] alunos = [];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o nome do aluno nº {i}: ");
            alunos[i] = Console.ReadLine();
        }


    }
}