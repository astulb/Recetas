using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

//Gianni
namespace DataAccess
{
    public class RecipesContext : DbContext
    {
        public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
            
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["RecipeDatabase"].ConnectionString);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=UY-IT00972\\SQLEXPRESS01; Initial Catalog=RecipeDatabase; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(bc => new { bc.RecipeID, bc.IngredientID });
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(bc => bc.Recipe)
                .WithMany(b => b.RecipeIngredients)
                .HasForeignKey(bc => bc.RecipeID);
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(bc => bc.Ingredient)
                .WithMany(c => c.RecipeIngredients)
                .HasForeignKey(bc => bc.IngredientID);
        }

    }
}
