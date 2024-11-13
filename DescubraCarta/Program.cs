using System;
using System.ComponentModel;
using System.Reflection;

namespace DescubraCarta
{
    public enum Naipe
    {
        [Description("Paus")]
        Paus = 0,
        [Description("Ouros")]
        Ouros = 1,
        [Description("Copas")]
        Copas = 2,
        [Description("Espadas")]
        Espadas = 3
    }

    public enum Valor
    {
        [Description("As")]
        As = 1,
        [Description("Valete")]
        Valete = 2,
        [Description("Dama")]
        Dama = 3,
        [Description("Rei")]
        Rei = 4
    }

    public class Carta(Naipe naipe, Valor valor)
    {
        public Naipe Naipe { get; private set; } = naipe;
        public Valor Valor { get; private set; } = valor;

        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public string GetNaipeDescricao() => GetEnumDescription(Naipe);
        public string GetValorDescricao() => GetEnumDescription(Valor);
    }

    public static class Program
    {
        private static int ObterValorEscolhido()
        {
            int valorEscolhido;
            Console.WriteLine("Escolha um Valor  de 1 a 4 : ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out valorEscolhido) && valorEscolhido >= 1 && valorEscolhido <= 4)
                {
                    return valorEscolhido;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Escolha um número entre 1 e 4.");
                }
            }
        }
        private static int ObterNaipeEscolhido()
        {
            int naipeEscolhido;
            Console.WriteLine("Escolha um Naipe de 0 a 3 : ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out naipeEscolhido) && naipeEscolhido >= 0 && naipeEscolhido <= 3)
                {
                    return naipeEscolhido;
                }
                else
                {
                    Console.WriteLine("Naipe inválido! Escolha um número entre 0 e 3.");
                }
            }
        }

        public static void Main(string[] args)
        {
            int valorEscolhido = ObterValorEscolhido();
            int naipeEscolhido = ObterNaipeEscolhido();

            Carta novaCarta = new((Naipe)naipeEscolhido, (Valor)valorEscolhido);

            string valorDescricao = novaCarta.GetValorDescricao();
            string naipeDescricao = novaCarta.GetNaipeDescricao();

            Console.WriteLine($"Carta escolhida: {valorDescricao} de {naipeDescricao}");
        }
    }
}
