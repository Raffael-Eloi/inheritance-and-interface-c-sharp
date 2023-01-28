using bytebank_ADM.Employees;

namespace bytebank_ADM.Tests
{
    [TestFixture]
    public class DesignerShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void When_Create_New_Designer_The_Default_Salary_Should_Be_Three_Thousand()
        {
            #region Arrange

            var name = "Patrick";
            var document = "345678910";

            #endregion

            #region Act

            Employee patrick = new Designer(name, document);

            #endregion

            #region Assert

            var expectedDefaultSalary = 3000;

            Assert.That(patrick, Is.InstanceOf<Employee>());
            Assert.That(patrick, Is.InstanceOf<Designer>());
            Assert.That(patrick.Salary, Is.EqualTo(expectedDefaultSalary));

            #endregion
        }

        [Test]
        public void When_Get_A_Bonus_The_Value_Should_Be_Seventeen_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Patrick";
            var document = "345678910";

            Employee patrick = new Designer(name, document);

            #endregion

            #region Act

            double bonus = patrick.GetBonus();

            #endregion

            #region Assert

            var expectedBonus = patrick.Salary * 0.17;

            Assert.That(bonus, Is.EqualTo(expectedBonus));

            #endregion
        }

        [Test]
        public void When_Increasy_Salary_The_Value_Should_Be_Increased_Eleven_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Patrick";
            var document = "345678910";

            Employee patrick = new Designer(name, document);

            #endregion

            #region Act

            var expectedSalaryAfterIncreased =  Math.Round(patrick.Salary + (patrick.Salary * 0.11), 2);

            patrick.IncreaseSalary();

            #endregion

            #region Assert

            var salaryRounded = Math.Round(patrick.Salary, 2);
            Assert.That(salaryRounded, Is.EqualTo(expectedSalaryAfterIncreased));

            #endregion
        }
    }
}
