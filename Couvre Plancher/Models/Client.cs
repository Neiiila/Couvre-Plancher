using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Couvre_Plancher.Models
{
    public class Client : Personne
    {
        public Client(string Cin, string Nom, DateTime DateNaissance, string Adresse, string NumTelephone) : base(Cin, Nom, DateNaissance, Adresse, NumTelephone)
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

    }
}
