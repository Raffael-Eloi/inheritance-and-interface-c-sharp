using bytebank_ADM.Employees;
using bytebank_ADM.InternSystem;
using bytebank_ADM.Utility;

#region

Employee pedro = new Assistant("123456789");
pedro.Name = "Pedro malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

Director roberta = new Director("987654321");
roberta.Name = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

BonusManager gerenciador = new BonusManager();
gerenciador.Register(pedro);
gerenciador.Register(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);


pedro.IncreaseSalary();
roberta.IncreaseSalary();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");

#endregion

#region

void CalcularBonificacao()
{
    BonusManager gerenciador = new BonusManager();

    Designer ulisses = new Designer("123456");
    ulisses.Name = "Ulisses Senna";

    Director paula = new Director("234567");
    paula.Name = "Paula Senna";

    Assistant igor = new Assistant("345678");
    igor.Name = "Igor Senna";

    AccountManager camila = new AccountManager("3456789");
    camila.Name = "Camila Senna";

    gerenciador.Register(ulisses);
    gerenciador.Register(paula);
    gerenciador.Register(igor);
    gerenciador.Register(camila);

    Console.WriteLine($"Total de bonificação = {gerenciador.BonusAmount}");
}

// CalcularBonificacao();

#endregion

#region
//void usarsistema()
//{
//    internsystem sistema = new internsystem();

//    director ingred = new director("234567");
//    ingred.name = "ingred senna";
//    ingred.password = "123";

//    accountmanager ursula = new accountmanager("345678");
//    ursula.name = "ursula senna";
//    ursula.password = "456";

//    sistema.login(ingred, "123");
//    sistema.login(ursula, "946");

//    parceirocomercial caio = new parceirocomercial();
//    caio.senha = "999";
//    sistema.logar(caio, "999");

//}

//usarsistema();

#endregion