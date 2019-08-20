using System;

namespace Telzir.Models
{
    public class Plano
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Porcentagem { get; set; }
        public DateTime Criado { get; set; }
        public DateTime Editado { get; set; }

        public Usuario Usuario { get; set; }
    }
}