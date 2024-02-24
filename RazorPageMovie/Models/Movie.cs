// DECLARACIÓN DE LIBRERIAS
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


// MODELO DE DESARROLLO APLICADO EN ESTE PROYECTO ES "MODEL FIRST"
namespace RazorPageMovie.Models
{
    public class Movie
    {
        // EN LA DECLARACION DE VARIABLES EL ? DESPUÉS DEL NOMBRE DE LA VARIABLE INDICA QUE PUEDE SER NULL
        public int Id { get; set; }
        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        // ANOTACIÓN DE TIPO DE DATO, PARA ESO SE UTILIZA EL USING DATAANNOTATIONS
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}
