class ValidaSenha
{
    static string VerificaForca(string senha) {

        if (senha.Length < 8)
            return "Sua senha é muito pequena !";

        bool temLetraMaiuscula = senha.Any(char.IsUpper);
        bool temLetraMinuscula = senha.Any(char.IsLower);
        bool temNumero = senha.Any(char.IsDigit);
        bool temCaracterEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

        List<string> palavrasComuns = ["senha", "qwert", "123456"];
        if (palavrasComuns.Any(s => senha.Contains(s)))
            return "Sua senha contem sequencias comuns";

        if (temLetraMaiuscula && temLetraMinuscula && temNumero && temCaracterEspecial)
        {
            return "Sua senha atende aos requisitos de segurança!";
        }
        else {
            return "Sua senha não atende aos requisitos de segurança";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Insira a senha para validar a força");
        string senha = Console.ReadLine().Trim();

        string resultado = VerificaForca(senha);
        Console.WriteLine(resultado);
    }
}