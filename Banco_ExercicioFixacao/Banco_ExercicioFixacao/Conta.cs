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

        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        // metodos
        public void DepositoConta(double deposito) {
            Saldo += deposito;
        }

        public void SaqueConta(double saque) {
            Saldo -=saque + 5.00;
        }

        public override string ToString() {
            return $"Conta { NumConta}, Titular: {Titular}, " +
                $" Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
