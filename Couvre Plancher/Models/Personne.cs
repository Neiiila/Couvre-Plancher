using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Couvre_Plancher.Models
{
    public class Personne
    {
        [Key]
        public string? Cin { get; set; }

        [StringLength(100)]
        public string? Nom { get; set; }

        [DataType(DataType.Date)]
        [StringLength(100)]
        public DateTime DateNaissance { get; set; }

        [DataType(DataType.Text)]
        [StringLength(300)]
        public string? Adresse { get; set; }

        [DataType(DataType.Text)]
        [StringLength(12)]
        public string? NumTelephone { get; set; }
     
        public Personne(string Cin, string Nom , DateTime DateNaissance, string Adresse, string NumTelephone) {
            this.Cin = Cin;
            this.Nom = Nom;
            this.DateNaissance = DateNaissance; 
            this.Adresse = Adresse;
            this.NumTelephone = NumTelephone;   
        }

    }
}
