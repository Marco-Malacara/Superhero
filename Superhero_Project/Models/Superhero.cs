using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Superhero_Project.Models
{
    public class Superhero 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
    public class SuperheroContext : DbContext
    {
        public DbSet<Superhero> Superhero { get; set; }
    }
}