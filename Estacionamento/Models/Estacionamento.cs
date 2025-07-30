using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamento
    {
        private List<Carro> carros = new List<Carro>();

        public void RegistrarEntradaDoCarro()
        {
            Carro carro = new Carro();

            Console.WriteLine("Digite a marca do carro");
            carro.Marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro");
            carro.Cor = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro");
            carro.Placa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(carro.Placa)) throw new ArgumentException("A placa é obrigatória!");

            if (carro.Placa.Length < 6 || carro.Placa.Length > 7) throw new ArgumentException("Placa inválida! Deve ter 6 ou 7 caracteres.");

            carros.Add(carro);

            Console.WriteLine("✅ Carro registrado com sucesso!");
        }
        public void ListarCarros()
        {
            Console.WriteLine("\n=== Lista de carros no estacionamento ===");
            foreach (var carro in carros)
            {
                Console.WriteLine($"Marca: {carro.Marca} | Modelo: {carro.Modelo} | Cor: {carro.Cor} | Placa: {carro.Placa}");
            }
            Console.WriteLine("=========================================");
        }

    }
}