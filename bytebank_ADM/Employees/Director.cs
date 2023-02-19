namespace bytebank_ADM.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string name, string document) : base(name, document, 5000)
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

        public override string ToString()
        {
            return $"Name: {Name} - Base salary: {Salary} - Bonus: {GetBonus()} - Position: {nameof(Director)}";
        }
    }
}