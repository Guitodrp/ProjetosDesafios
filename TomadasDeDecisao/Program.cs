class TomadasDeDecisao
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o saldo total de sua conta bancária");
        double saldoTotal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de saque desejado");
        double valorSaque = Convert.ToDouble(Console.ReadLine());

        if (valorSaque > saldoTotal)
        {
            Console.WriteLine("Saldo insuficiente. Saque nao realizado !");
            Console.WriteLine("Saldo Total: {0:0.00}", saldoTotal, "Valor de saque: {0:0.00}", valorSaque);
        }
        else
        {
            Console.WriteLine("Saldo Total: {0:0.00}", saldoTotal, "Valor de saque: {0:0.00}", valorSaque);
            saldoTotal = saldoTotal - valorSaque;
            Console.WriteLine("Saque realizado com sucesso! Novo saldo: {0:0.00}", saldoTotal);
        }
    }
}