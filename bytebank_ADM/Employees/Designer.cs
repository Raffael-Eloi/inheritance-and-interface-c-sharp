namespace bytebank_ADM.Employees
{
    internal class Designer : Employee
    {
        public Designer(string document) : base(document, 3000)
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