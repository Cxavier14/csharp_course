using System;
using System.Globalization;

namespace Banco_ExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S') {
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numConta, titular, depInicial);
            }
            else {
                conta = new Conta(numConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.DepositoConta(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.SaqueConta(saq);
            Console.WriteLine(conta);
            


        }
    }
}
