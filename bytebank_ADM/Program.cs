using bytebank_ADM.Employees;
using bytebank_ADM.Utility;

namespace bytebank_ADM
{
    public class Program
    {
        static void Main() 
        {
            BonusManager bonusManager = new BonusManager();

            Employee jorge = new Assistant("Jorge", "0123456");
            bonusManager.Register(jorge);

            Console.WriteLine(jorge.ToString());

            Employee alice = new Designer("Alice", "1234567");
            bonusManager.Register(alice);

            Console.WriteLine(alice.ToString());

            Employee robson = new Director("Robson", "2345678");
            bonusManager.Register(robson);

            Console.WriteLine(robson.ToString());
            bonusManager.Register(jorge);

            Employee maria = new AccountManager("Maria", "1234567");
            bonusManager.Register(maria);

            Console.WriteLine(maria.ToString());

            Console.WriteLine($"The total of employees's bonus is R$ {bonusManager.BonusAmount}");
        }
    }
}