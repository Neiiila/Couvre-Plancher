using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Couvre_Plancher.Models
{
    public class Superviseur : Personne
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public String? Username { get; set; } // ? nullable


        [StringLength(150)]
        [DataType(DataType.EmailAddress)]
        public String? Email { get; set; }

        [StringLength(150)]
        [DataType(DataType.Password)]
        public String? Password { get; set; }

        public Superviseur(string Cin, string Nom, DateTime DateNaissance, string Adresse, string NumTelephone, string username, string email, string password)
            : base( Cin,  Nom,  DateNaissance,  Adresse,  NumTelephone)
        {
            Username = username;
            Email = email;
            Password = password;
        }       
    }

}
