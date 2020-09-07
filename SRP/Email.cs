namespace S.O.L.I.D.SRP
{
    public class Email : IValidate
    {
        public string EmailAdress { get; set; } 

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.EmailAdress) &&
                    this.EmailAdress.Contains("@");
        }

        public override string ToString()
        {
            return EmailAdress;
        }
    }
}