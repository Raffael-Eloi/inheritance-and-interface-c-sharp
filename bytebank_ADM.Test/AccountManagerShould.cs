using bytebank_ADM.Employees;

namespace bytebank_ADM.Tests
{
    [TestFixture]
    public class AccountManagerShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void When_Create_New_Account_Manager_The_Default_Salary_Should_Be_Four_Thousand()
        {
            #region Arrange

            var name = "Alice";
            var document = "456789101";

            #endregion

            #region Act

            Employee alice = new AccountManager(name, document);

            #endregion

            #region Assert

            var expectedDefaultSalary = 4000;

            Assert.That(alice, Is.InstanceOf<Employee>());
            Assert.That(alice, Is.InstanceOf<AccountManager>());
            Assert.That(alice.Salary, Is.EqualTo(expectedDefaultSalary));

            #endregion
        }

        [Test]
        public void When_Get_A_Bonus_The_Value_Should_Be_Twenty_Five_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Alice";
            var document = "456789101";

            Employee alice = new AccountManager(name, document);

            #endregion

            #region Act

            double bonus = alice.GetBonus();

            #endregion

            #region Assert

            var expectedBonus = alice.Salary * 0.25;

            Assert.That(bonus, Is.EqualTo(expectedBonus));

            #endregion
        }

        [Test]
        public void When_Increasy_Salary_The_Value_Should_Be_Increased_Five_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Alice";
            var document = "456789101";

            Employee alice = new AccountManager(name, document);

            #endregion

            #region Act

            var expectedSalaryAfterIncreased = alice.Salary + (alice.Salary * 0.05);

            alice.IncreaseSalary();

            #endregion

            #region Assert

            Assert.That(alice.Salary, Is.EqualTo(expectedSalaryAfterIncreased));

            #endregion
        }
    }
}
