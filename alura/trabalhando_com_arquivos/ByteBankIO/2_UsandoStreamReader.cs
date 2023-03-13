using bytebank.Modelos.Conta;

partial class Program
{
    static void UsandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxodoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxodoArquivo);
            //var linha = leitor.ReadLine();
            //var texto = leitor.ReadToEnd(); // não é muito bom em casos de arquivos muito grandes pois é lido de uma vez
            //var numero = leitor.Read(); // Traz o primeiro byte do arquivo

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine(); // útil para arquivos grandes pois imprime aos poucos
                var contaCorrente = ConverteStringParaContaCorrente(linha);
                var msg = $"Conta número {contaCorrente.Conta}, ag {contaCorrente.Numero_agencia}, saldo {contaCorrente.Saldo}, titular {contaCorrente.Titular.Nome}";

                Console.WriteLine(msg);
            }


        }
        Console.ReadLine();
    }

    static ContaCorrente ConverteStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');
        var numero_agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];

        var agenciaComString = numero_agencia;
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaComString, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }

}


