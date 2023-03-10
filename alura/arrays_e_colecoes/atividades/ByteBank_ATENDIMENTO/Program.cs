using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using ByteBank_ATENDIMENTO.bytebank.exceptions;
using System;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region TestaArray
//TestaArrayInt();
//BuscaStringArray();

void TestaArrayInt()
{
    int[] idade = new int[5];
    idade[0] = 20;
    idade[1] = 23;
    idade[2] = 19;
    idade[3] = 29;
    idade[4] = 33;

    int acumulador = 0;

    Console.WriteLine($"Tamanho Array: {idade.Length}");

    for (int i = 0; i < idade.Length; i++)
    {
        int idades = idade[i];
        Console.WriteLine("indice[" + i + "] = " + idade[i]);
        acumulador += idades;
    }

    int media = acumulador / idade.Length;
    Console.WriteLine($"Media de idade = {media}");

}
void BuscaStringArray()
{
    string[] palavras = new string[5];

    for(int i = 0; i< palavras.Length; i++)
    {
        Console.Write($"Digite a palavra {i + 1}: ");
        palavras[i] = Console.ReadLine();
    }
    Console.WriteLine("Que palavra deseja buscar? ");
    var busca = Console.ReadLine();

    foreach(string palavra in palavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }

}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(7, 1);
amostra.SetValue(3.2, 2);
amostra.SetValue(1, 3);
amostra.SetValue(9, 4);

//TestaMedianaArray(amostra);

void TestaMedianaArray(Array array)
{
    if (array == null || array.Length == 0){
        Console.WriteLine("Não é possível calcular a mediana do array indicado");
    }

    double[] numerosOrdenados = (double[]) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
          numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

    Console.WriteLine($"Com base na amostra a mediana é {mediana}");
}

void TestaArrayDeObjetos()
{
    ListaDeContasCorrentes listadecontas = new ListaDeContasCorrentes();
    listadecontas.adicionar(new ContaCorrente("8479834", 873));
    listadecontas.adicionar(new ContaCorrente("7345837", 356));
    listadecontas.adicionar(new ContaCorrente("8727383", 892));
    listadecontas.adicionar(new ContaCorrente("6373827", 783));
    listadecontas.adicionar(new ContaCorrente("7382749", 028));
    listadecontas.adicionar(new ContaCorrente("1892097", 289));
    //ContaCorrente contadoAndre = new ContaCorrente(672);
    //listadecontas.adicionar(contadoAndre);
    //listadecontas.ExibeLista();
    //listadecontas.remove(contadoAndre);
    //listadecontas.ExibeLista();

    for (int i = 0; i < listadecontas.Tamanho; i++)
    {
        ContaCorrente conta = listadecontas[i];
        Console.WriteLine($"Indice: {i} | Conta: {conta.Numero_agencia}");
    }


}

TestaArrayDeObjetos();

#endregion

List<ContaCorrente> listadecontas = new List<ContaCorrente>()
{
   // new ContaCorrente("7263762",550)
};
AtendimentoCliente();

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===        Atendimento        ===");
            Console.WriteLine("=== 1 Cadastrar conta         ===");
            Console.WriteLine("=== 2 Listar contas           ===");
            Console.WriteLine("=== 3 Remover conta           ===");
            Console.WriteLine("=== 4 Ordenar contas          ===");
            Console.WriteLine("=== 5 Pesquisar conta         ===");
            Console.WriteLine("=== 6 Sair do sistema         ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n\n");
            Console.WriteLine("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
            

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarConta();
                    break;
                case '3':
                   RemoverConta();
                    break;
                case '4':
                    OrdenarConta();
                    break;
                case '5':
                    PesquisarConta();
                    break;
                default:
                    Console.WriteLine("opcao nao implementada");
                    break;
            }
        }
    }
    catch(ByteBankException excecao) 
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void PesquisarConta()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("===     PESQUISAR CONTAS      ===");
    Console.WriteLine("=================================");
    Console.WriteLine("\n");

    Console.WriteLine("Deseja pesquisar por (1) NUMERO DA CONTA ou (2) CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
        {
                Console.WriteLine("Informe o número da conta: ");
                string numeroConta = Console.ReadLine();
                ContaCorrente consultaconta = ConsultaNumeroConta(numeroConta);
                Console.ReadKey();
                Console.WriteLine(consultaconta.ToString);
                break;
        }
        case 2:
        {
                Console.WriteLine("Informe o cpf da conta: ");
                string cpfConta = Console.ReadLine();
                ContaCorrente consultaconta = ConsultaCpfConta(cpfConta);
                Console.ReadKey();
                Console.WriteLine(consultaconta.ToString);
                break;
            }
    }
}

ContaCorrente ConsultaCpfConta(string? cpfConta)
{
    ContaCorrente conta = null;
    for(int i =0; i<listadecontas.Count; i++)
    {
        if (listadecontas[i].Titular.Cpf.Equals(cpfConta)){
            conta = listadecontas[i];
        }
    }
    return conta;
}

ContaCorrente ConsultaNumeroConta(string? numeroConta)
{
    ContaCorrente conta = null;
    for (int i = 0; i < listadecontas.Count; i++)
    {
        if (listadecontas[i].Titular.Cpf.Equals(numeroConta)){
            conta = listadecontas[i];
        }
    }
    return conta;
}

void OrdenarConta()
{
    listadecontas.Sort();
    Console.WriteLine("Lista de contas ordenadas");
    Console.ReadKey();
}

void RemoverConta()
{
    Console.WriteLine("=================================");
    Console.WriteLine("===      REMOVER CONTAS      ===");
    Console.WriteLine("=================================");
    Console.WriteLine("\n");

    Console.WriteLine("Informe o número da conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;

    foreach(var item in listadecontas)
    {
        if (item.Conta.Equals(numeroConta)){
            conta = item;
        }
    }
    if(conta!= null)
    {
        listadecontas.Remove(conta);
        Console.WriteLine("Conta removida da lista!");
    }
    else
    {
        Console.WriteLine("Conta não encontrada!");
    }
}

void CadastrarConta(){
    Console.WriteLine("=================================");
    Console.WriteLine("===     CADASTRO DE CONTAS    ===");
    Console.WriteLine("=================================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe os dados da conta ===");

    Console.WriteLine("Numero da conta:");
    string numeroConta = Console.ReadLine();

    Console.WriteLine("Numero da Agência:");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroConta, numeroAgencia);

    Console.WriteLine("Insira o saldo inicial:");
    conta.Saldo= double.Parse(Console.ReadLine());

    Console.WriteLine("Insira o nome do Titular:");
    conta.Titular.Nome = Console.ReadLine();

    Console.WriteLine("Insira o CPF do Titular:");
    conta.Titular.Cpf= Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    listadecontas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();


}

void ListarConta()
{
    Console.WriteLine("=================================");
    Console.WriteLine("===     LISTAGEM DE CONTAS    ===");
    Console.WriteLine("=================================");
    Console.WriteLine("/n");

    if(listadecontas.Count<=0){
        Console.WriteLine("Não há contas cadastradas");
        Console.ReadKey();
        return;
    }
    foreach(ContaCorrente item in listadecontas){
        Console.WriteLine("==== Dados da Conta ====");
        Console.WriteLine($"Numero da conta: {item.Conta}");
        Console.WriteLine($"Numero da agencia: {item.Numero_agencia}");
        Console.WriteLine($"Saldo da conta: {item.Saldo}");
        Console.WriteLine($"Titular da conta: {item.Titular.Nome}");
        Console.WriteLine ($"CPF do titular: {item.Titular.Cpf}");
        Console.WriteLine($"Profissao do titular: {item.Titular.Profissao}");
        Console.WriteLine("========================");
        Console.ReadKey ();
    }
}