using Microsoft.AspNetCore.Mvc;
using Servless_GeracaoDeBoleto.Model;
using Servless_GeracaoDeBoleto.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servless_GeracaoDeBoleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerarBoletoController : ControllerBase
    {
        GerarBoletoRepository gerarBoleto = new GerarBoletoRepository();
        // POST api/<GerarBoletoController>
        [HttpPost]
        public BoletoModel GertarBoleto([FromBody] string value)
        {
            BoletoModel boleto = new BoletoModel();

            boleto = gerarBoleto.GerarBoleto(value);

            return boleto;
        }

    }
}
