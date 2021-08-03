using System;
using System.Globalization;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {

            Hospede[] hospede = new Hospede[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                hospede[room] = new Hospede(name, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if(hospede[i] != null) {
                    Console.WriteLine(i + ": " + hospede[i]);
                }
            }

        }


    }
}

