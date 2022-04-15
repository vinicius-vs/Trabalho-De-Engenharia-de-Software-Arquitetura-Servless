using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servless_GeracaoDeBoleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerarBoletoController : ControllerBase
    {
       
        // POST api/<GerarBoletoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
