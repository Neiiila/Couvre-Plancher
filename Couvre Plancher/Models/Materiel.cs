using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Couvre_Plancher.Models
{
    public class Materiel
    {
            [Key]
            public string? Nom { get; set; }

            public float PrixParMetre { get; set; }

            public float PrixMainOeuvre { get; set; }
    }
}

