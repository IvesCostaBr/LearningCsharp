using System;
namespace LearningApp.Conta
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        const double taxaSaque = 5.00;



        public ContaBancaria(string titular ,int numero) { //Sobrecarga de construtores
            NumeroConta = numero;
            Titular = titular;

        }

        public ContaBancaria( string titular, int numero, double saldo) :this(titular, numero) {
            Saldo = saldo;
        }

        public void Sacar(double valorSaque) {
            if (valorSaque <= Saldo)
            {
                Console.WriteLine($"Saldo anterior: {Saldo}");
                Saldo -= valorSaque - taxaSaque;
                Console.WriteLine($"Saque realizado, Novo saldo{Saldo}");
            }
            else {
                Console.WriteLine("Impossivel realizar o saque!Sem saldo suficiente.");
            }

        }

        public void Deposito(double valorDeposito) { 
            Saldo += valorDeposito;
            Console.WriteLine(this);
        }

        public override string ToString() //__str__
        {
            return " Conta :"
                + NumeroConta
                + ", Titular:"
                + Titular
                + ", Saldo: R$  "
                + Saldo;
        }
    }
}
