namespace bytebank_ADM.InternSystem
{
    public interface IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password);
    }
}
