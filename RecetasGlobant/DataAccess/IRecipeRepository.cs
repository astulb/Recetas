using System;
using System.Collections.Generic;
using System.Text;
using Domain;

//Ivan
//GetAllRecipes()

//GetAllIngredients()

//AddRecipe(Recipe recipe)

//DeleteRecipe(Recipe recipe)
namespace DataAccess
{
    public  interface IRecipeRepository
    {
        public abstract  List<Recipe> GetAllRecipes();

        public abstract void AddRecipe(Recipe recipe);

        public abstract void DeleteRecipe(Recipe recipe);

        public abstract List<Ingredient> GetAllIngredients(Ingredient ingredient);

    }
}
