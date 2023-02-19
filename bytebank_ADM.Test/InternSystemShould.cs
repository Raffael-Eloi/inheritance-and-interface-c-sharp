using bytebank_ADM.Employees;
using bytebank_ADM.InternSystem;

namespace bytebank_ADM.Test
{
    [TestFixture]
    public class InternSystemShould
    {
        InternEmployeeSystem internEmployeeSystem;

        [SetUp]
        public void SetUp()
        {
            internEmployeeSystem = new ();
        }

        private static AuthenticableEmployee CreateAccountManagerEmployee()
        {
            return new AccountManager("Alice", "3456789")
            {
                Password = "asdfg123"
            };
        }

        [Test]
        public void Login_Authenticable_User_When_Password_Is_Correct()
        {
            #region Arrange

            AuthenticableEmployee alice = CreateAccountManagerEmployee();

            #endregion

            #region Act

            bool isLoginSuccessful = internEmployeeSystem.LogIn(alice, alice.Password);

            #endregion

            #region Assert

            Assert.IsTrue(isLoginSuccessful);

            #endregion
        }

        [Test]
        public void Not_Login_Authenticable_User_When_Password_Is_Incorrect()
        {
            #region Arrange

            AuthenticableEmployee alice = CreateAccountManagerEmployee();

            #endregion

            #region Act

            var incorrectPassword = "akdfaka8945";
            bool isLoginSuccessful = internEmployeeSystem.LogIn(alice, incorrectPassword);

            #endregion

            #region Assert

            Assert.IsFalse(isLoginSuccessful);

            #endregion
        }
    }
}
