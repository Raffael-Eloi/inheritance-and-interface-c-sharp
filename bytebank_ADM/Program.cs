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

            //BonusManager bonusManager = new();

            //Employee jorge = new Assistant("Jorge", "0123456");
            //bonusManager.Register(jorge);
            //Console.WriteLine(jorge.ToString());

            //Employee alice = new Designer("Alice", "1234567");
            //bonusManager.Register(alice);
            //Console.WriteLine(alice.ToString());

            //Employee robson = new Director("Robson", "2345678");
            //bonusManager.Register(robson);
            //Console.WriteLine(robson.ToString());

            //Employee maria = new AccountManager("Maria", "3456789");
            //bonusManager.Register(maria);
            //Console.WriteLine(maria.ToString());

            //Console.WriteLine($"The total of employees's bonus is R$ {bonusManager.BonusAmount}");

            #endregion

            #region Authenticable Employees

            //InternEmployeeSystem internEmployeeSystem = new();

            //AuthenticableEmployee alexander = new Director("Alexander", "4567890")
            //{
            //    Password = "asd123"
            //};

            //internEmployeeSystem.LogIn(alexander, alexander.Password);


            //AuthenticableEmployee sabrina = new AccountManager("Sabrina", "5678901") 
            //{
            //    Password = "efg456" 
            //};

            //var invalidPassword = "adjafl45a6545a";

            //internEmployeeSystem.LogIn(sabrina, invalidPassword);

            #endregion

            #region Arrays - Collections

            int[] ages = new int[5];
            ages[0] = 10;
            ages[1] = 20;
            ages[2] = 30;
            ages[3] = 40;
            ages[4] = 50;

            Console.WriteLine(ages.First());

            string[] words = new string[2] { "Plate", "Water" };
            Console.WriteLine(words.First());
            Console.WriteLine(words.Last());

            double[] values = { 1.8, 6.9, 3.7 };
            Console.WriteLine(values.First());
            Console.WriteLine(values.Last());

            #endregion
        }
    }
}