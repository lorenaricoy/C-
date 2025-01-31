﻿using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salaio) : base(cpf, salaio)
        {
        }

        public string Senha { get ; set  ; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
