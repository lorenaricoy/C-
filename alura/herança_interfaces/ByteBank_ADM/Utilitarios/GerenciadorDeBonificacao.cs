﻿using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar (Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.getBonificacao();
        }

    }
}
