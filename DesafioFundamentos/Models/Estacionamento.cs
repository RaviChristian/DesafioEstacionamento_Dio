namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Placa = Console.ReadLine();
            Veiculos.Add(Placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string Placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == Placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string Horas = Console.ReadLine();
                int horas;
                decimal valorTotal;

                if (int.TryParse(Horas,out horas)) 
                {
                    valorTotal = (precoInicial + precoPorHora) * horas;
                    Veiculos.Remove(Placa);
                    Console.WriteLine($"O veículo {Placa} foi removido e o preço total foi de: R$ {valorTotal}");

                }
                else {
                    Console.WriteLine("Digite um valor válido");
                }


            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Veiculos.ForEach((e) => Console.WriteLine(e));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
