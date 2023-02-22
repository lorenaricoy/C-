﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    internal class Designer:Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override double getBonificacao()
        {
            return this.Salario * 0.17 ;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
