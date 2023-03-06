using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        public int prxPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial=5)
        {
            _itens= new ContaCorrente[tamanhoInicial];
        }

        public void adicionar (ContaCorrente itens)
        {
            VerificaTamanho(prxPosicao+1);
            _itens[prxPosicao]=itens;
            prxPosicao++;
        }

        public void remove (ContaCorrente conta)
        {
            int indice = 0;
            for(int i =0; i < _itens.Length; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indice = i;
                    break;
                }
            }

            for (int i= indice; indice<prxPosicao-1; i++)
            {
                _itens[i] = _itens[i+1];
            }

            prxPosicao--;
            _itens[prxPosicao] = null;
        }

        public void VerificaTamanho(int tamanhonecessario)
        {
            if (tamanhonecessario <= _itens.Length)
            {
                return;
            }
            Console.WriteLine("Aumentando capacidade da lista");
            ContaCorrente[] novoarray = new ContaCorrente[tamanhonecessario];

            for(int i =0; i<_itens.Length; i++)
            {
                novoarray[i] = _itens[i];
            }
            _itens = novoarray;
        }

        public void ExibeLista()
        {
            for(int i=0; i<_itens.Length; i++) 
            {
                if (_itens[i] != null)
                {
                    Console.WriteLine($"Indice {i} Conta: {_itens[i].Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperaItemIndice(int indice)
        {
            if(indice<0||indice>=prxPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        } 

        public int Tamanho
        {
            get
            {
                return prxPosicao;
            }
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperaItemIndice(indice);
            }
        }
    }
}
