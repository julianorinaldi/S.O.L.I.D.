namespace SOLID.SRP
{
    public class CPF : IValidate
    {
        public string CPF_ID { get; set; } 

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.CPF_ID) &&
                    this.CPF_ID.Length == 11;
        }

        public override string ToString()
        {
            return CPF_ID;
        }
    }
}