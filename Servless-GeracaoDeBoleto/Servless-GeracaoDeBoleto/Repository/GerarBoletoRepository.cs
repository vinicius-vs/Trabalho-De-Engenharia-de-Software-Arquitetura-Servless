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

            servico = buscarInfoRepository.BuscarServisoPorClente(cliente);

            boleto.CodigoDeBarra = buscarInfoRepository.GerarCodigo();
            boleto.Servico = servico;  
            boleto.Cliente = cliente;
            boleto.DataCompetencia = DateTime.Today;
            boleto.DataValidade = DateTime.Today.AddDays(20);


            return boleto;
        }
    }
}
