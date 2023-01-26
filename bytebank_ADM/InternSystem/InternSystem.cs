namespace bytebank_ADM.InternSystem
{
    public class InternSystem
    {
        public static bool LogIn(IAuthenticable employee, string password)
        {
            bool isEmployeeAuthenticated = employee.Authenticate(password);

            if (isEmployeeAuthenticated)
            {
                Console.WriteLine("Welcome to our system.");
                return true;
            }

            Console.WriteLine("Incorrect password.");
            return false;
        }
    }
}