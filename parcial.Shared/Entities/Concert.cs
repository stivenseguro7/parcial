using System.ComponentModel.DataAnnotations;

namespace parcial.Shared.Entities
{
    public class Concert
    {
        public int Id { get; set; }

        [Display(Name = "fecha de ingreso")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres. el formato es dd/mm/aaaa")] // fecha en formato dd/mm/aaaa
        public string FechaUso { get; set; } = null!;

        public bool FueUsada { get; set; }

        public string porteria { get; set; } = null!;

        [Display(Name = "hora de ingreso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(5, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres. el formato es hora en formato 00:00 (hora militar)")] // hora en formato 00:00 (hora militar)
        public string Hora { get; set; } = null!;

    }
}
