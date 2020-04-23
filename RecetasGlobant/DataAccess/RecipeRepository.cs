using System;
using System.Collections.Generic;
using Domain;


namespace DataAccess
{
    public class RecipeRepository : IRecipeRepository
    {
        RecipesContext db = new RecipesContext();
        public void AddRecipe(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            Recipe recipeFound = db.Recipes.FirstOrDefault(x => x.Id == recipe.Id);
            db.Recipes.Remove(recipeFound);
            db.SaveChanges();
        }

        public List<Ingredient> GetAllIngredients(Ingredient ingredient)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            var ingredientList = db.Ingredients.ToList();
            for (int i = 0; i < ingredientList.Count; i++)
            {
                ingredients.Add(ingredientList[i]);

            }

            return ingredients;
        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            var recipeList = db.Recipes.ToList();
            for (int i = 0; i < recipeList.Count; i++)
            {
                recipes.Add(recipeList[i]);

            }

            return recipes;
        }
    }
}
