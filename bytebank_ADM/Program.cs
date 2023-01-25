using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region

Funcionario pedro = new Funcionario("123456789", 2000);
pedro.Nome = "Pedro malazartes";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321");
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);


pedro.AumentarSalario();
roberta.AumentarSalario();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");

#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Senna";

    Diretor paula = new Diretor("234567");
    paula.Nome = "Paula Senna";

    Auxiliar igor = new Auxiliar("345678");
    igor.Nome = "Igor Senna";

    GerenteDeContas camila = new GerenteDeContas("3456789");
    camila.Nome = "Camila Senna";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de bonificação = {gerenciador.TotalDeBonficacao}");
}

CalcularBonificacao();