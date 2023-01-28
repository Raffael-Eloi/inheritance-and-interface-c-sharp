using bytebank_ADM.Employees;

namespace bytebank_ADM.Tests
{
    [TestFixture]
    public class AssistentShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void When_Create_New_Assistant_The_Default_Salary_Should_Be_Two_Thousand()
        {
            #region Arrange

            var name = "Jhon";
            var document = "123456789";

            #endregion

            #region Act

            Employee jhon = new Assistant(name, document);

            #endregion

            #region Assert

            var expectedDefaultSalary = 2000;

            Assert.That(jhon, Is.InstanceOf<Employee>());
            Assert.That(jhon, Is.InstanceOf<Assistant>());
            Assert.That(jhon.Salary, Is.EqualTo(expectedDefaultSalary));

            #endregion
        }

        [Test]
        public void When_Get_A_Bonus_The_Value_Should_Be_Twenty_Percent_Of_The_Salary()
        {
            #region Arrange

            var name = "Jhon";
            var document = "123456789";

            Employee jhon = new Assistant(name, document);

            #endregion

            #region Act

            double bonus = jhon.GetBonus();

            #endregion

            #region Assert

            var expectedBonus = jhon.Salary * 0.2;

            Assert.That(bonus, Is.EqualTo(expectedBonus));

            #endregion
        }
    }
}
