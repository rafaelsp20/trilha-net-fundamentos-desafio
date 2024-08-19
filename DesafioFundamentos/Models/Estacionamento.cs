namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos" // NO TODO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();          

             if (placa == "")
                    {
                        Console.WriteLine("Não é possível cadastrar a placa do veículo, (Campo Vazio).");
                    }
                    else
                    {
                       veiculos.Add(placa); 
                    }    
            }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");                  

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();           

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");            
                string dados = Console.ReadLine();                              
                int horas = Convert.ToInt32(dados);
                
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado, / NO TODO
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal  
                       
                // *IMPLEMENTE AQUI*
                decimal valorTotal = precoInicial + (precoPorHora * horas); //+ (precoPorHora; //* horas);
                // int horas = 0;
                // decimal valorTotal = 0;                

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI
                veiculos.Remove(placa);   
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}.");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                
                int quantidade = veiculos.Count();
                Console.WriteLine($"Os veículos estacionados são: {quantidade}");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                 foreach(string item in veiculos)
                {
                Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        } 
        public void Encerrar()
        {
            int quantidade = 0;
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Operação não pode ser realizada, existem carros estacionados");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados             
            }
            else
            {
              
                Console.WriteLine("Saindo do Sistema...");              
                Environment.Exit(0);
            }
        }   
   
    }
}

