namespace bytebank_ADM.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string name, string document) : base(name, document, 2000)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.2;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Base salary: {Salary} - Bonus: {GetBonus()} - Position: {nameof(Assistant)}";
        }
    }
}