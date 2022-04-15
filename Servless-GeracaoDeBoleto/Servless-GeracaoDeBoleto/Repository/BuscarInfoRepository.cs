using Servless_GeracaoDeBoleto.Model;

namespace Servless_GeracaoDeBoleto.Repository
{
    public class BuscarInfoRepository
    {
        private List<UserModel> listaClinte;

        private List<ServicoModel> listaServico;

        public UserModel PesquisarCliente(string cpf)
        {
            UserModel cliente = new UserModel();
            
            foreach (UserModel user in listaClinte)
            {
                if(user.Cpf == cpf)
                {
                    cliente = user; 
                }
            }
            return cliente;
        }
        public ServicoModel BuscarServisoPorClente(UserModel cliente)
        {
            ServicoModel servico = new ServicoModel();

            foreach (ServicoModel servicoServico in listaServico)
            {
                if(servicoServico.Cliente.Cpf == cliente.Cpf)
                {
                    servico = servicoServico;  
                }
            }

            return servico;
        }
    }
}
