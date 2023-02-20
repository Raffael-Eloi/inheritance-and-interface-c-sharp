using bytebank_ADM.Employees;

namespace bytebank_ADM.Utility
{
    public class EmployeesManager
    {
        public double BonusAmount { get; private set; }

        public IList<Employee> Employees { get; private set; }

        public EmployeesManager()
        {
            Employees = new List<Employee>();
        }

        public void Register(Employee employee)
        {
            BonusAmount += employee.GetBonus();
            Employees.Add(employee);
        }

        public void ShowEmployeesRegistered()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employee registered: {Employees.IndexOf(employee)} - Name: {employee.Name}");
            }

            Console.WriteLine($"Total of employees registered: {Employees.Count}");
        }

        public void ClearEmployeesList()
        {
            Employees.Clear();
        }

        public bool IsEmployeeAdded(Employee jhon)
        {
            return Employees.Contains(jhon);
        }

        public void RemoveEmployee(Employee jhon)
        {
            if (IsEmployeeAdded(jhon))
            {
                Employees.Remove(jhon);
            }
        }
    }
}