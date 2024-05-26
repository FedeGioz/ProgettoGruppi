using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProgettoGruppi.Models
{
    public class SegnalazioneModel
    {
        [Required]
        public string Problema { get; set; }

        [Required]
        public string Luogo { get; set; }

        [Required]
        public int Priorita { get; set; }
    }
}
