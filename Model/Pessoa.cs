using System.ComponentModel.DataAnnotations;

namespace VSComMDB.Model
{
    public class Pessoa
    {

        [MaxLength(100)]    
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string? Celular { get; set; }

        [MaxLength(9)]
        public string CEP { get; set;}
    }
}
