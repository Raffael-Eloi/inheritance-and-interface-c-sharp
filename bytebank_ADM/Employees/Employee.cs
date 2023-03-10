namespace bytebank_ADM.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; } = string.Empty;

        public string Document { get; set; }

        public double Salary { get; protected set; }

        public static int EmployeesAmount { get; private set; }
        
        public Employee(string name, string document, double salary)
        {
            Name = name;
            Document = document;
            Salary = salary;
            EmployeesAmount++;
        }

        public abstract double GetBonus();

        public abstract void IncreaseSalary();
    }
}