using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            int numeroDeUmFuncionario = int.Parse(Console.ReadLine());
            int numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorQueRecebePorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculaSalario = numeroDeHorasTrabalhadas * valorQueRecebePorHora;

            Console.WriteLine($"NUMBER = {numeroDeUmFuncionario}");
            Console.WriteLine("SALARY = U$ " + calculaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
