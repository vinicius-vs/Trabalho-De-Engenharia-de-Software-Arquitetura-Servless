using Servless_GeracaoDeBoleto.Model;

namespace Servless_GeracaoDeBoleto.Repository
{
    public class GerarBoletoRepository
    {
      
        private BuscarInfoRepository BuscarInfoRepository = new BuscarInfoRepository();
        public BoletoModel GerarBoleto(string cpf)
        {

            return Boleto;
        }
    }
}
