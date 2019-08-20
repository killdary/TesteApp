using System.ComponentModel.DataAnnotations;

namespace Telzir.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}