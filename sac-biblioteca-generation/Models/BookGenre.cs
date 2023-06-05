using System.ComponentModel.DataAnnotations;

namespace sac_biblioteca_generation.Models
{
    public class BookGenre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il campo può contenere al massimo 50 caratteri")]
        public string Nome { get; set; }

        public List<Book> Books { get; set; }


        public BookGenre()
        {

        }

        public BookGenre(string nome)
        {
            Nome = nome;
            Books = new List<Book>();
        }
    }
}
