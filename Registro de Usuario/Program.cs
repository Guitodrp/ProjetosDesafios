using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registro_de_Usuario;

class Cadastro(string nomeUsuario, string emailCadastro, string password)
{
    string NomeUsuario { get; set; } = nomeUsuario;
    string EmailCadastro { get; set; } = emailCadastro;
    string Password { get; set; } = password;

    public void MensagemAtivacao()
    {
        Console.WriteLine($"{NomeUsuario}, verifique o email: {EmailCadastro} para ativar !");
    }
}

public class Principal
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o email: ");
        string email = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Digite a senha: ");
        string password = Console.ReadLine();
        Console.WriteLine();

        Cadastro newCadastro = new(nome, email, password);
        newCadastro.MensagemAtivacao();
    }
}