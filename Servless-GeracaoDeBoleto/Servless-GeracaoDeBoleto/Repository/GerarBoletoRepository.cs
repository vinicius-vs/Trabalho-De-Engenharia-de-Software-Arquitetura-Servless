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

            Random rand = new Random(); 

            cliente = buscarInfoRepository.PesquisarCliente(cpf);

            servico = buscarInfoRepository.BuscarServisoPorClente(cliente);

            boleto.CodigoDeBarra = Convert.ToString( rand.Next(10000, 99999)) + " " + Convert.ToString(rand.Next(10000, 99999)) + "" + Convert.ToString(rand.Next(10000, 99999));
            boleto.Servico = servico;  
            boleto.Cliente = cliente;
            boleto.DataCompetencia = DateTime.Today;
            boleto.DataValidade = DateTime.Today.AddDays(20);


            return boleto;
        }
    }
}
