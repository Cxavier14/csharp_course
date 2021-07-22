using System;
using System.Globalization;

namespace Banco_ExercicioFixacao {
    class Conta {

        // propriedades
        public string Titular { get; set; }
        public int NumConta { get; private set; }
        public double Saldo { get; private set; }

        // construtores
        public Conta(int numero, string titular) {
            NumConta = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular) {
            DepositoConta(depositoInicial);
        }

        // metodos
        public void DepositoConta(double quantia) {
            Saldo += quantia;
        }

        public void SaqueConta(double quantia) {
            Saldo -= quantia + 5.00;
            // para saques, há uma taxa a ser descontada no valor de 5.00 reais
        }

        public override string ToString() {
            return $"Conta { NumConta}, Titular: {Titular}, " +
                $" Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
