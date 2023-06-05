using System.ComponentModel.DataAnnotations;

namespace sac_biblioteca_generation.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "Il campo può contenere 100 caratteri")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "Il campo può contenere 100 caratteri")]
        public string Cognome { get; set; }

        public List<Book> Books { get; set; }

        public Authors()
        {

        }

        public Authors(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        
    }
}
