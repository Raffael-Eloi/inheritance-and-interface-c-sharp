using bytebank_ADM.InternSystem;

namespace bytebank_ADM.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public AuthenticableEmployee(string document, double salary) : base(document, salary)
        {
        }

        public string Password { get; set; }


        public bool Authenticate(string senha)
        {
            return Password.Equals(senha);
        }

    }
}
