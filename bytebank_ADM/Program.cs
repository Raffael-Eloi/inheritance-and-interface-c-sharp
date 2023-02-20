using bytebank_ADM.Employees;
using bytebank_ADM.InternSystem;
using bytebank_ADM.Utility;

namespace bytebank_ADM
{
    public class Program
    {
        static void Main()
        {
            #region Employees

            EmployeesManager bonusManager = new();

            Employee jorge = new Assistant("Jorge", "0123456");
            bonusManager.Register(jorge);
            Console.WriteLine(jorge.ToString());

            Employee alice = new Designer("Alice", "1234567");
            bonusManager.Register(alice);
            Console.WriteLine(alice.ToString());

            Employee robson = new Director("Robson", "2345678");
            bonusManager.Register(robson);
            Console.WriteLine(robson.ToString());

            Employee maria = new AccountManager("Maria", "3456789");
            bonusManager.Register(maria);
            Console.WriteLine(maria.ToString());

            Console.WriteLine($"The total of employees's bonus is R$ {bonusManager.BonusAmount}");
           bonusManager.ShowEmployeesRegistered();

            #endregion

            #region Authenticable Employees

            InternEmployeeSystem internEmployeeSystem = new();

            AuthenticableEmployee alexander = new Director("Alexander", "4567890")
            {
                Password = "asd123"
            };

            internEmployeeSystem.LogIn(alexander, alexander.Password);


            AuthenticableEmployee sabrina = new AccountManager("Sabrina", "5678901")
            {
                Password = "efg456"
            };

            var invalidPassword = "adjafl45a6545a";

            internEmployeeSystem.LogIn(sabrina, invalidPassword);

            #endregion
        }
    }
}