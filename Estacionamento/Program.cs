namespace Estacionamento;

public class Principal
{

    public class Estacionamento(decimal precoInicial, decimal precoFinal)
    {
        private decimal PrecoInicial { get; set; } = precoInicial;
        private decimal PrecoPorHora { get; set; } = precoFinal;
        private List<string> Veiculos { get; set; } = [];

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para adicionar: ");
            string placa = Console.ReadLine().ToUpper();
            if (Veiculos.Contains(placa))
            {
                Console.WriteLine("O veículo já está estacionado");
            }
            else
            {
                Veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine().ToUpper();

            if (Veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas de permanecimento: ");
                decimal horas = int.Parse(Console.ReadLine());
                decimal valorTotal = ((horas * PrecoPorHora) + PrecoInicial);

                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Listagem de veículos: \r\n");
            if (Veiculos.Count > 0)
            {
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Agora digite o preço por hora:");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();

        Estacionamento estacionamento = new(precoInicial, precoPorHora);

        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("Sistema de estacionamento" +
                "\r\n Menu" +
                "\r\n  1. Cadastrar veículo" +
                "\r\n  2. Remover veículo" +
                "\r\n  3. Listar veículos" +
                "\r\n  4. Encerrar" +
                "\r\n");

            switch (Console.ReadLine())
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    exibirMenu = false;
                    Console.WriteLine("Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção Invalida!");
                    break;
            }
            Console.WriteLine();
        }
    }
}