using bytebank_ADM.Employees;

namespace bytebank_ADM.Tests
{
    [TestFixture]
    public class DirectorShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void When_Create_New_Director_The_Default_Salary_Should_Be_Five_Thousand()
        {
            #region Arrange

            var name = "Bernard";
            var document = "234567891";

            #endregion

            #region Act

            Employee bernard = new Director(name, document);

            #endregion

            #region Assert

            var expectedDefaultSalary = 5000;

            Assert.That(bernard, Is.InstanceOf<Employee>());
            Assert.That(bernard, Is.InstanceOf<Director>());
            Assert.That(bernard.Salary, Is.EqualTo(expectedDefaultSalary));

            #endregion
        }

        [Test]
        public void When_Get_A_Bonus_The_Value_Should_Be_Fifty_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Bernard";
            var document = "234567891";

            Employee bernard = new Director(name, document);

            #endregion

            #region Act

            double bonus = bernard.GetBonus();

            #endregion

            #region Assert

            var expectedBonus = bernard.Salary * 0.5;

            Assert.That(bonus, Is.EqualTo(expectedBonus));

            #endregion
        }

        [Test]
        public void When_Increasy_Salary_The_Value_Should_Be_Increased_Fifteen_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Bernard";
            var document = "234567891";

            Employee bernard = new Director(name, document);

            #endregion

            #region Act

            var expectedSalaryAfterIncreased = bernard.Salary + (bernard.Salary * 0.15);

            bernard.IncreaseSalary();

            #endregion

            #region Assert

            Assert.That(bernard.Salary, Is.EqualTo(expectedSalaryAfterIncreased));

            #endregion
        }
    }
}
