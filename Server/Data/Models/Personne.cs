using System.ComponentModel.DataAnnotations;

namespace Gestion.Parc.Informatique.Data
{
    public class Personne : EntityBase
    {
        [Required]
        public string? Nom { get; set; }
        [Required]
        public string? Prenom { get; set; }
        [Required]
        public int Age { get; set; }

    }
}