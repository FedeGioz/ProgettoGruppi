using ProgettoGruppi.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgettoGruppi.Models
{
    public class Segnalazione
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        [Required]
        public string Problema { get; set; }

        [Required]
        public string Luogo { get; set; }

        [Required]
        public int Priorita { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
