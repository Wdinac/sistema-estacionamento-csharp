using System;
using System.Collections.Generic;

namespace SistemaEstacionamento {
    class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa)) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu:");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {valorTotal}");
            } else {
                Console.WriteLine("Veículo não encontrado!");
            }
        }

        public void ListarVeiculos() {
            if (veiculos.Count > 0) {
                Console.WriteLine("Veículos estacionados:");
                foreach (var v in veiculos) {
                    Console.WriteLine(v);
                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Estacionamento estacionamento = new Estacionamento(5.0m, 2.0m);

            bool exibirMenu = true;

            while (exibirMenu) {
                Console.WriteLine("\nDigite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine()) {
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
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine("Programa encerrado!");
        }
    }
}