using Domain;
using System;
using System.Collections.Generic;
using System.Text;

//Meli
namespace BusinessLogic
{
    public interface IRecipeBL
    {
        public ICollection<Recipe> GetAllRecipes();

        public ICollection<Ingredient> GetAllIngredients();

        public ICollection<Ingredient> GetRecipe(int recipeId);

        public void AddRecipe(Recipe recipe);

        public void DeleteRecipe(int recipeId);
    }
}
