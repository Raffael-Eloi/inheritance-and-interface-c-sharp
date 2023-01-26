namespace bytebank_ADM.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string document) : base(document, 5000)
        {

        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }
    }
}