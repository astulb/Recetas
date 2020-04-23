using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

//Gianni
namespace DataAccess
{
    public class RecipesContext : DbContext
    {
        public RecipesContext()
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
            
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(bc => new { bc.RecipeID, bc.IngredientID });
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(bc => bc.Recipe)
                .WithMany(b => b.RecipeIngredients)
                .HasForeignKey(bc => bc.IngredientID);
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(bc => bc.Ingredient)
                .WithMany(c => c.RecipeIngredients)
                .HasForeignKey(bc => bc.RecipeID);
        }

    }
}
