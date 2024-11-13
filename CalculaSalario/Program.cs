
using System.Buffers;
using System.Net;

public class AumentoDeSalario
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o salário do funcionário");
        var salario = Convert.ToDouble(Console.ReadLine());

        double percentual, reajuste, novoSalario;

        if (salario < 0.0)
        {
            return;
        }
        else if (salario > 0.0 && salario <= 400.0)
        {
            percentual = 15.0/100.0;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;
        }

        else if (salario > 400 && salario <= 800)
        {
            percentual = 12.0 / 100.0;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;
        }

        else if (salario > 800 && salario <= 1200)
        {
            percentual = 10.0 / 100.0;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;
        }

        else if (salario > 1200 && salario <= 2000)
        {
            percentual = 7.0 / 100.0;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;
        }

        else
        {
            percentual = 4.0 / 100.0;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;
        }

        Console.WriteLine("Percentual de aumento : {0} %", percentual * 100);
        Console.WriteLine("Valor de reajuste : {0:0.00}", reajuste);
        Console.WriteLine("Novo salario : {0:0.00}", novoSalario);
    }

}
