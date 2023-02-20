using bytebank_ADM.Employees;
using bytebank_ADM.Utility;

namespace bytebank_ADM.Test
{
    [TestFixture]
    public class EmployeesManagerShould
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

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);
            employeesManager.Register(bernard);
            employeesManager.Register(alice);

            #endregion

            #region Assert

            var expectedBonus = jhon.GetBonus() + bernard.GetBonus() + alice.GetBonus();

            Assert.That(employeesManager.BonusAmount, Is.EqualTo(expectedBonus));

            #endregion
        }

        [Test]
        public void When_Register_The_Employee_Should_Be_Added_To_The_Employees_List()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();
            Employee alice = CreateAccountManagerEmployee();

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);
            employeesManager.Register(alice);

            #endregion

            #region Assert

            Assert.That(employeesManager.Employees.Count(), Is.EqualTo(2));
            Assert.That(employeesManager.Employees.First(), Is.EqualTo(jhon));
            Assert.That(employeesManager.Employees.Last(), Is.EqualTo(alice));

            #endregion
        }

        [Test]
        public void When_Clear_The_Employees_List_Should_Be_Empty()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();
            Employee alice = CreateAccountManagerEmployee();

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);
            employeesManager.Register(alice);

            employeesManager.ClearEmployeesList();

            #endregion

            #region Assert

            Assert.That(employeesManager.Employees.Count, Is.EqualTo(0));

            #endregion
        }

        [Test]
        public void Return_True_When_Employee_Exist_In_List_Of_Employees()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);

            bool employeeExist= employeesManager.IsEmployeeAdded(jhon);

            #endregion

            #region Assert

            Assert.That(employeeExist, Is.True);

            #endregion
        }

        [Test]
        public void Return_False_When_Employee_Does_Not_Exist_In_List_Of_Employees()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            bool employeeExist = employeesManager.IsEmployeeAdded(jhon);

            #endregion

            #region Assert

            Assert.That(employeeExist, Is.False);

            #endregion
        }

        [Test]
        public void Remove_Employee_When_Exist()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.RemoveEmployee(jhon);

            #endregion

            #region Assert

            Assert.That(employeesManager.Employees.Count, Is.EqualTo(0));

            #endregion
        }

        [Test]
        public void Return_Employee_When_Exist_Employee_Registered_With_Given_Document()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();

            string document = jhon.Document;

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);

            Employee? employee = employeesManager.GetEmployeeWithDocument(document);

            #endregion

            #region Assert

            Assert.That(employee, Is.Not.Null);

            #endregion
        }

        [Test]
        public void Not_Return_Employee_When_Does_Not_Exist_Employee_Registered_With_Given_Document()
        {
            #region Arrange

            Employee jhon = CreateAssistantEmployee();

            string notExistingDocument = "111111";

            #endregion

            #region Act

            var employeesManager = new EmployeesManager();

            employeesManager.Register(jhon);

            Employee? employee = employeesManager.GetEmployeeWithDocument(notExistingDocument);

            #endregion

            #region Assert

            Assert.That(employee, Is.Null);

            #endregion
        }
    }
}
