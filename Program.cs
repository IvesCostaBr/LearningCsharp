using System;
using LearningApp.Conta;

namespace LearningApp
{
    class Program
    {
        static void Main()
        {
            ContaBancaria conta;

            Console.WriteLine("Digite o nome do titular:");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Digite o numero da conta:");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Avera deposito inicial");
            string resp = Console.ReadLine();


            if (resp == "s" || resp == "S")
            {

                Console.WriteLine("Digite o valor do deposito:");
                double valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(nomeTitular, numeroConta, valor);
                Console.WriteLine(conta);
            }
            else {

                conta = new ContaBancaria(nomeTitular, numeroConta);
                Console.WriteLine(conta);
            }

            conta.Deposito(500);

           
        }
    }
}
