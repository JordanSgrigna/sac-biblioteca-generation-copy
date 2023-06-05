using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sac_biblioteca_generation.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "Il campo nome può contenere al massimo 100 caratteri")]
        public string Titolo { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Descrizione { get; set; }

        public bool? VersioneCartaceaDisponibile { get; set; }

        public DateTime? Prestito { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Url(ErrorMessage = "L'url inserito non è valido")]
        public string UrlImmagine { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public bool Disponibilità { get; set; }

        public int GenreId { get; set; }
        public BookGenre Genre { get; set; }

        public int AuthorsId { get; set;}
        public Authors Authors { get; set; }

        public Book()
        {

        }

        public Book(string titolo, string descrizione, string urlImmagine, bool versioneCartaceaDisponibile)
        {
            Titolo = titolo;
            Descrizione = descrizione;
            UrlImmagine = urlImmagine;
            VersioneCartaceaDisponibile = versioneCartaceaDisponibile;
        }
    }
}
