using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class RegistroEstacionamento
    {
        public Veiculo Veiculo { get; set; }
        public int HoraEntrada { get; set; }
        public int HoraSaida { get; set; }
        public int ValorHoraInicial = 5;
        public int ValorHoraAdicional = 2;

        public int ValorTotal;

        public void CadastrarEntradaNoEstacionamento()
        {
            RegistrarEntrada();

            Console.WriteLine("Hora Inicial R$ 5,00\nDemais Horas R$ 2,00");

            Console.WriteLine("Digite a hora de entrada");
            HoraEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o horário de saída");
            HoraSaida = int.Parse(Console.ReadLine());
        }
        public void CalcularTotalEstacionamento()
        {
            int totalDeHoras = HoraSaida - HoraEntrada;
            if (totalDeHoras <= 1)
            {
                ValorTotal = ValorHoraInicial;
            }
            else
            {
                ValorTotal = ValorHoraInicial + (totalDeHoras - 1) * ValorHoraAdicional;

            }

            Console.WriteLine($"Valor Total Pago: R$ " + ValorTotal);

        }

        public void RegistrarEntrada()
        {
            Veiculo = new Veiculo();

            Console.WriteLine("Digite o modelo do veiculo");
            Veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a placa do veiculo");
            Veiculo.Placa = Console.ReadLine();

            Console.WriteLine("Digite a cor do veiculo");
            Veiculo.Cor = Console.ReadLine();
        }

        public void ImprimirNotaFiscal()
        {
            Console.WriteLine("\n========== NOTA FISCAL ESTACIONAMENTO ==========");
            Console.WriteLine($"Modelo do veículo: {Veiculo?.Modelo ?? "Não informado"}");
            Console.WriteLine($"Placa: {Veiculo?.Placa ?? "Não informado"}");
            Console.WriteLine($"Cor: {Veiculo?.Cor ?? "Não informado"}");
            Console.WriteLine($"Hora de entrada: {HoraEntrada}h");
            Console.WriteLine($"Hora de saída: {HoraSaida}h");
            Console.WriteLine($"Valor da 1ª hora: R$ {ValorHoraInicial},00");
            Console.WriteLine($"Valor por hora adicional: R$ {ValorHoraAdicional},00");
            Console.WriteLine($"Total a pagar: R$ {ValorTotal},00");
            Console.WriteLine("===============================================\n");
        }
    }
}