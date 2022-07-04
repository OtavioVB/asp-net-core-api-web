using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
    }
}
