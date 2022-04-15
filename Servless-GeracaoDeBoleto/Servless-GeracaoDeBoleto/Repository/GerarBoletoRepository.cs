using Servless_GeracaoDeBoleto.Model;

namespace Servless_GeracaoDeBoleto.Repository
{
    public class GerarBoletoRepository
    {
      
        private BuscarInfoRepository buscarInfoRepository = new BuscarInfoRepository();
        public BoletoModel GerarBoleto(string cpf)
        {
            BoletoModel boleto = new BoletoModel();
            UserModel cliente = new UserModel();
            ServicoModel servico = new ServicoModel();

            cliente = buscarInfoRepository.PesquisarCliente(cpf);

            return boleto;
        }
    }
}
