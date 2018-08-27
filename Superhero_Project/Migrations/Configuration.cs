namespace Superhero_Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Superhero_Project.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Superhero_Project.Models.ApplicationDbContext>
    {
        
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Superhero_Project.Models.ApplicationDbContext context)
        {
            context.Superheros.AddOrUpdate(x => x.Id,
            new Models.Superhero() { Id = 1, Name = "Batman", AlterEgo = "Bruce Wayne", PrimaryAbility = "Billionaire Playboy", SecondaryAbility = "Ninja training", Catchphrase = "I am Batman!"},
            new Models.Superhero() { Id = 2, Name = "Deadpool", AlterEgo = "Wade Wilson", PrimaryAbility = "Regenerative Healing", SecondaryAbility = "Medium Awarness", Catchphrase = "Maximum effort!"},
            new Models.Superhero() { Id = 3, Name = "Spiderman", AlterEgo = "Peter Parker", PrimaryAbility = "All abilities of a spider", SecondaryAbility = "Enhanced suit made by Tony Stark", Catchphrase = "My spider sense is tingling"},
            new Models.Superhero() { Id = 4, Name = "Iron Man", AlterEgo = "Tony Stark", PrimaryAbility = "Billionaire Genius", SecondaryAbility = "Speciality designed suit of armour with weapons", Catchphrase = "No official catchprase"},
            new Models.Superhero() { Id = 5, Name = "Superman", AlterEgo = "Clark Kent", PrimaryAbility = "Super Alien Strenght", SecondaryAbility = "Virtually industructable", Catchphrase = "Up, Up, and Away!"}
            );
        }
    }
}
