namespace Servless_GeracaoDeBoleto.Model
{
    public class BoletoModel
    {
        public string CodigoDeBarra { get; set; }
        public UserModel Cliente { get; set; }
        public ServicoModel Servico { get; set; }
        public DateTime DataCompetencia { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
