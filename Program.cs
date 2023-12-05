using System;
using System.Globalization;
using System.Collections.Generic;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo moedaBrasil = new CultureInfo("pt-BR");
            Random random = new Random();

            Console.Write("Digite o seu nome:");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o seu nome:");
            string senha = Console.ReadLine();

            List<string> titular = GeradorTitular(random);

            Console.Write("Digite o seu saldo:");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CriacaoContaBanco bank = new CriacaoContaBanco(nome, senha ,titular, saldo);

            Console.WriteLine(bank);
        }

        private static List<string> GeradorTitular(Random random)
        {
            List<string> titular = new List<string>();

            for (int i = 0; i < 1; i++)
            {
                int numeroAleatorio;

                do
                {
                    numeroAleatorio = random.Next(10000);
                } while (titular.Contains(numeroAleatorio.ToString()));

                titular.Add(numeroAleatorio.ToString());
            }

            return titular;
        }
    }
}
