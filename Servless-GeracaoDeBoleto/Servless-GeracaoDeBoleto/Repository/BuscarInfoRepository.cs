using Servless_GeracaoDeBoleto.Model;

namespace Servless_GeracaoDeBoleto.Repository
{
    public class BuscarInfoRepository
    {
        private List<UserModel> listaClinte ;

        private List<ServicoModel> listaServico;

        public BuscarInfoRepository()
        {

            listaClinte = new List<UserModel>();
            listaServico = new List<ServicoModel>();
         

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                UserModel user = new UserModel();
                ServicoModel servicoModel = new ServicoModel();

                user.NomeCompleto = "Teste " + Convert.ToString(i);
                user.Cpf = "000000000-0" + Convert.ToString(i);

                listaClinte.Add(user);

                servicoModel.nome = "Serviço "+ Convert.ToString(i);
                servicoModel.Descricao = "Serviço " + Convert.ToString(i);
                servicoModel.valor =  random.Next(90, 300);
                servicoModel.Cliente = user;

                listaServico.Add(servicoModel);

            }
        }


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
        public string GerarCodigo()
        {
            Random rand = new Random();
            return Convert.ToString(rand.Next(10000, 99999)) + " " + Convert.ToString(rand.Next(10000, 99999)) + " " + Convert.ToString(rand.Next(10000, 99999)) + " " + Convert.ToString(rand.Next(10000, 99999)) + " " + Convert.ToString(rand.Next(0, 9)); 
        }
    }
}
