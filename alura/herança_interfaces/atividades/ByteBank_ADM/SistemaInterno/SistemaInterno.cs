using System;
using ByteBank_ADM.Funcionarios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar (IAutenticavel funcionarios, string senha)
        {
            bool funcionarioAutenticado = funcionarios.Autenticar(senha);
            if(funcionarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            Console.WriteLine("Senha incorreta");
            return false;
        }
    }
}
