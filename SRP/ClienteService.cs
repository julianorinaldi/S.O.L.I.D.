
namespace S.O.L.I.D.SRP
{
    public class ClienteService
    {
        public string AdicionarCliente(SOLID_SRP_Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email.EmailAdress, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}