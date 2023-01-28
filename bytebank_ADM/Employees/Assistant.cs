﻿namespace bytebank_ADM.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string document) : base(document, 2000)
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
    }
}