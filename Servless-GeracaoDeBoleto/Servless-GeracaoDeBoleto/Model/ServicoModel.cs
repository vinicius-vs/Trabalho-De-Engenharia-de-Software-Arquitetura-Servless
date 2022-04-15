namespace Servless_GeracaoDeBoleto.Model
{
    public class ServicoModel
    {
        public string nome { get; set; }
        public string Descricao { get; set; }
        public decimal valor { get; set; }
        public UserModel Cliente { get; set; }
    }
}
