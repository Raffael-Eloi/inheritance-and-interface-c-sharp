using bytebank_ADM.InternSystem;

namespace bytebank_ADM.CommercialPartner
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return Password.Equals(password);
        }
    }
}
