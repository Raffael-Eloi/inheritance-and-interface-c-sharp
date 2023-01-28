namespace bytebank_ADM.Employees
{
    public class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string name, string document) : base(name, document, 4000)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.25;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }
    }
}