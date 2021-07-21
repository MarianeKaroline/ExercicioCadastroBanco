using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            double deposito = 0.0;
            Console.Write("Digite o número da conta bancária: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja fazer um depósito inicial? (S/N) ");
            char op = char.Parse(Console.ReadLine().ToUpper());

            switch (op)
            {
                case 'S':
                    Console.Write("Por favor, digite o valor a ser depositado: $");
                    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    break;
                case 'N':
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            ContaBancaria cb = new ContaBancaria(numeroConta, nome, deposito);

            Console.WriteLine(cb);

            while (opc != 0)
            {
                Console.WriteLine("\n-------------------------------------\n");
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("\nDigite o valor a ser depositado: $");
                        cb.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        break;
                    case 2:
                        Console.Write("\nDigite o valor a ser sacado: $");
                        cb.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        break;
                    case 0:
                        Console.WriteLine("Saindo..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente");
                        continue;
                }
                Console.WriteLine("\n-------------------------------------\n");
                Console.WriteLine(cb);

            }

        }
    }
}
