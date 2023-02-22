using System;
using ByteBank.Titular;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set { this.numero_agencia = value; }
        }

        public string Conta { get; set; }
        public static int TotalDeContas { get; set; } 
        private double saldo;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            setSaldo(getSaldo()+valor);
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.numero_agencia=numero_agencia;
            this.Conta= numero_conta;
            TotalDeContas++;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                setSaldo(getSaldo()-valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor <= saldo)
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double getSaldo()
        {
            return this.saldo;
        }
    }
}
