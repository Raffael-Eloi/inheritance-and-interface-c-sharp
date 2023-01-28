using bytebank_ADM.InternSystem;

namespace bytebank_ADM.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public AuthenticableEmployee(string name, string document, double salary) : base(name, document, salary)
        {
        }

        public string Password { get; set; } = string.Empty;


        public bool Authenticate(string senha)
        {
            return Password.Equals(senha);
        }

    }
}
