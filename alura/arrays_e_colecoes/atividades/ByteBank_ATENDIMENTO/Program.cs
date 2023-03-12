using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using ByteBank_ATENDIMENTO.bytebank.atendimento;
using ByteBank_ATENDIMENTO.bytebank.exceptions;
using System;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

#region TestaArray
// TestaArrayInt();
// BuscaStringArray();

// void TestaArrayInt()
// {
//     int[] idade = new int[5];
//     idade[0] = 20;
//     idade[1] = 23;
//     idade[2] = 19;
//     idade[3] = 29;
//     idade[4] = 33;

//     int acumulador = 0;

//     Console.WriteLine($"Tamanho Array: {idade.Length}");

//     for (int i = 0; i < idade.Length; i++)
//     {
//         int idades = idade[i];
//         Console.WriteLine("indice[" + i + "] = " + idade[i]);
//         acumulador += idades;
//     }

//     int media = acumulador / idade.Length;
//     Console.WriteLine($"Media de idade = {media}");

// }
// void BuscaStringArray()
// {
//     string[] palavras = new string[5];

//     for(int i = 0; i< palavras.Length; i++)
//     {
//         Console.Write($"Digite a palavra {i + 1}: ");
//         palavras[i] = Console.ReadLine();
//     }
//     Console.WriteLine("Que palavra deseja buscar? ");
//     var busca = Console.ReadLine();

//     foreach(string palavra in palavras)
//     {
//         if (palavra.Equals(busca))
//         {
//             Console.WriteLine($"Palavra encontrada = {busca}");
//             break;
//         }
//     }

// }

// Array amostra = Array.CreateInstance(typeof(double), 5);
// amostra.SetValue(5.9, 0);
// amostra.SetValue(7, 1);
// amostra.SetValue(3.2, 2);
// amostra.SetValue(1, 3);
// amostra.SetValue(9, 4);

// //TestaMedianaArray(amostra);

// void TestaMedianaArray(Array array)
// {
//     if (array == null || array.Length == 0){
//         Console.WriteLine("Não é possível calcular a mediana do array indicado");
//     }

//     double[] numerosOrdenados = (double[]) array.Clone();
//     Array.Sort(numerosOrdenados);

//     int tamanho = numerosOrdenados.Length;
//     int meio = tamanho / 2;

//     double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//           numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

//     Console.WriteLine($"Com base na amostra a mediana é {mediana}");
// }

// void TestaArrayDeObjetos()
// {
//     ListaDeContasCorrentes listadecontas = new ListaDeContasCorrentes();
//     listadecontas.adicionar(new ContaCorrente("8479834", 873));
//     listadecontas.adicionar(new ContaCorrente("7345837", 356));
//     listadecontas.adicionar(new ContaCorrente("8727383", 892));
//     listadecontas.adicionar(new ContaCorrente("6373827", 783));
//     listadecontas.adicionar(new ContaCorrente("7382749", 028));
//     listadecontas.adicionar(new ContaCorrente("1892097", 289));
//     //ContaCorrente contadoAndre = new ContaCorrente(672);
//     //listadecontas.adicionar(contadoAndre);
//     //listadecontas.ExibeLista();
//     //listadecontas.remove(contadoAndre);
//     //listadecontas.ExibeLista();

//     for (int i = 0; i < listadecontas.Tamanho; i++)
//     {
//         ContaCorrente conta = listadecontas[i];
//         Console.WriteLine($"Indice: {i} | Conta: {conta.Numero_agencia}");
//     }


// }

// TestaArrayDeObjetos();

#endregion

