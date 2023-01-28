namespace bytebank_ADM.Employees
{
    public class Designer : Employee
    {
        public Designer(string name, string document) : base(name, document, 3000)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.17;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }
    }
}