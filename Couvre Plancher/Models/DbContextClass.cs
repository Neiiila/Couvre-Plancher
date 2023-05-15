using Microsoft.EntityFrameworkCore;
using Couvre_Plancher.Models; 
namespace Couvre_Plancher.Models
{
    public class DbContextClass: DbContext
    {

        public DbContextClass( DbContextOptions<DbContextClass> options) : base(options) 
        { 
        
        }

        public DbSet<CouvrePlanche> couvrePlanches { get; set; }
        public DbSet<Superviseur> superviseurs { get; set; }
    }

    
}
