namespace ValidadorDeCpf;

public class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite um CPF para validar ___.___.___-__ \r\n");
        string cpf = Console.ReadLine();
        Console.WriteLine();

        if (ValidaCPF(cpf) == true)
        {
            Console.WriteLine("O CPF digitado é valido!");
        }
        else
        {
            Console.WriteLine("O CPF digitado é invalido!");
        }
    }

    public static bool ValidaCPF(string cpf)
    {

        //Verifica se e nulo
        if (string.IsNullOrEmpty(cpf))
            return false;

        //Tira traços e pontos
        cpf = cpf.Replace(".", "").Replace("-", "");

        //Verifica tamanho
        if (cpf.Length != 11)
            return false;

        //Verifica se é numero
        if (!cpf.All(char.IsNumber))
            return false;

        //Transforma em array
        var cpfArray = cpf.ToCharArray();

        // Primeira Parte (Primeiro Dígito Verificador)
        var peso = 10;
        var soma = 0;

        for (var i = 0; i < 9; i++)
            soma += (cpfArray[i] - '0') * peso--;
        var resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        if (cpfArray[9] - '0' != resto)
            return false;

        // Segunda Parte (Segundo Dígito Verificador)
        peso = 11;
        soma = 0;

        for (var i = 0; i < 10; i++)
            soma += (cpfArray[i] - '0') * peso--;
        resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        if (cpfArray[10] - '0' != resto)
            return false;

        return true;
    }
}