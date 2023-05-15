using Couvre_Plancher.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Couvre_Plancher.Models
{
    public class CouvrePlanche
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[StringLength(100)]
        public string? Titre { get; set; }

        public float Prix { get; set; }

        //[DataType(DataType.Text)]
        public string? Description { get; set; }
        public string? ImgLink {get; set;}

        public virtual ICollection<Materiel>? Materiels { get; set; }    

    }

    

}
