using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(string cpf, double salaio)
        {
            TotalDeFuncionarios++;
            this.Cpf = cpf;
            this.Salario = salaio;
        }

        public abstract double getBonificacao();

        public abstract void aumentarSalario();

    }
}
