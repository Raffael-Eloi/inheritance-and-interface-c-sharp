using bytebank_ADM.Employees;

namespace bytebank_ADM.Utility
{
    public class BonusManager
    {
        public double BonusAmount { get; private set; }

        public void Register(Employee employee)
        {
            BonusAmount += employee.GetBonus();
        }
    }
}