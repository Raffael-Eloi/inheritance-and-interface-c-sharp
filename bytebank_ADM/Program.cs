using bytebank_ADM.Employees;

namespace bytebank_ADM
{
    public class Program
    {
        static void Main() 
        {
            #region Employees

            Employee jorge = new Assistant("Jorge", "0123456");

            Console.WriteLine(jorge.ToString());

            Employee alice = new Designer("Alice", "1234567");

            Console.WriteLine(alice.ToString());

            Employee robson = new Director("Robson", "2345678");

            Console.WriteLine(robson.ToString());

            Employee maria = new AccountManager("Maria", "1234567");

            Console.WriteLine(maria.ToString());

            #endregion
        }
    }
}