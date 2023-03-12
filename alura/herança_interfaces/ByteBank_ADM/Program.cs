using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceiro;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitarios;

SistemaInterno sistema = new SistemaInterno();
Diretor caio = new Diretor("898927");
Designer sofia = new Designer("787379");
Auxiliar jose = new Auxiliar("732883");
GerenteDeContas melissa = new GerenteDeContas("536726");
ParceiroComercial sergio = new ParceiroComercial();

caio.Nome = "Caio";
caio.Senha = "123";
Console.WriteLine("Olá " + caio.Nome);
sistema.Logar(caio, "123");

melissa.Nome = "Melissa";
melissa.Senha = "456";
Console.WriteLine("Olá " + melissa.Nome);
sistema.Logar(melissa, "123");

sergio.Senha = "789";
sistema.Logar(sergio, "123");


Console.WriteLine("Total de funcionarios:" + Funcionario.TotalDeFuncionarios);

Console.WriteLine("Salario diretor: " + caio.Salario);
caio.aumentarSalario();
Console.WriteLine("Salario diretor com aumento: "+ caio.Salario);

Console.WriteLine("Salario designer: " + sofia.Salario);
sofia.aumentarSalario();
Console.WriteLine("Salario designer com aumento: " + sofia.Salario);

Console.WriteLine("Salario auxiliar: " + jose.Salario);
jose.aumentarSalario();
Console.WriteLine("Salario auxiliar com aumento: " + jose.Salario);

Console.WriteLine("Salario gerente de contas: " + melissa.Salario);
melissa.aumentarSalario();
Console.WriteLine("Salario gerente de contas com aumento: " + melissa.Salario);

Console.WriteLine("Caio bonificacao: " + caio.getBonificacao());
Console.WriteLine("Sofia bonificacao: " + sofia.getBonificacao());
Console.WriteLine("Jose bonificacao: " + jose.getBonificacao());
Console.WriteLine("Melissa bonificacao: " + melissa.getBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(caio);
gerenciador.Registrar(sofia);
gerenciador.Registrar(jose);
gerenciador.Registrar(melissa);

Console.WriteLine("Bonificacao geral: " + gerenciador.TotalDeBonificacao);




