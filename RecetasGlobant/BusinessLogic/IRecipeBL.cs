using Domain;
using System;
using System.Collections.Generic;
using System.Text;

//Meli
namespace BusinessLogic
{
    public interface IRecipeBL
    {
        public ICollection<Recipe> GetRecipes();

        public ICollection<Ingredient> GetIngredients();

        public void AddRecipe(Recipe recipe);

        public void DeleteRecipe(int recipeId);
}
