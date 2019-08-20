namespace Telzir.Models
{
    public class Pacote
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Minutos { get; set; }
        public int Tipo { get; set; }

        public Plano Plano { get; set; }
    }
}