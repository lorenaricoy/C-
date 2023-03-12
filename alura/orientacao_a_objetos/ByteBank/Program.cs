using ByteBank.Contas;
using ByteBank.Titular;

ContaCorrente conta = new ContaCorrente(10, "1010-X");
Cliente cliente = new Cliente();

cliente.Nome = "Andre Silva";
cliente.Cpf = "1829892";
cliente.Profissao = "cozinheiro";

conta.Titular = cliente;
conta.setSaldo(100);

Console.WriteLine(conta.Titular.Nome);
Console.WriteLine(conta.Titular.Cpf);
Console.WriteLine(conta.Titular.Profissao);
Console.WriteLine(conta.Conta);
Console.WriteLine(conta.Numero_agencia);
Console.WriteLine(conta.getSaldo());
Console.WriteLine(ContaCorrente.TotalDeContas);