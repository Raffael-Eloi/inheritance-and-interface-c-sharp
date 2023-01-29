using bytebank_ADM.Employees;
using bytebank_ADM.Utility;

namespace bytebank_ADM.Test
{
    [TestFixture]
    public class BonusManagerShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        private static Employee CreateAssistantEmployee()
        {
            return new Assistant("Jhon", "1234567");
        }

        private static Employee CreateDirectorEmployee()
        {
            return new Director("Bernard", "2345678");
        }

        private static Employee CreateAccountManagerEmployee()
        {
            return new AccountManager("Alice", "3456789");
        }

        [Test]
        public void When_Register_An_Employee_Get_The_Bonus()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();
            Employee bernard = CreateDirectorEmployee();
            Employee alice = CreateAccountManagerEmployee();

            #endregion

            #region Act

            var bonusManager = new BonusManager();

            bonusManager.Register(jhon);
            bonusManager.Register(bernard);
            bonusManager.Register(alice);

            #endregion

            #region Assert

            var expectedBonus = jhon.GetBonus() + bernard.GetBonus() + alice.GetBonus();

            Assert.That(bonusManager.BonusAmount, Is.EqualTo(expectedBonus));

            #endregion
        }
    }
}
