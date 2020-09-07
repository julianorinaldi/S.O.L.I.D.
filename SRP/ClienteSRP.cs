using System;

namespace SOLID.SRP 
{
        public class SOLID_SRP_Cliente : IValidate
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return Email.IsValid() && Cpf.IsValid();
        }
    }
}