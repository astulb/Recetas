using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain;


namespace DataAccess
{
    public class RecipeRepository : IRecipeRepository
    {
        RecipesContext db;

        public RecipeRepository(RecipesContext recipesContext)
        {
            db = recipesContext;
        }

        public void AddRecipe(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
        }

        public void DeleteRecipe(int id)
        {
            Recipe recipeFound = db.Recipes.FirstOrDefault(x => x.RecipeID == id);
            db.Recipes.Remove(recipeFound);
            db.SaveChanges();
        }

        public List<Ingredient> GetAllIngredients()
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
            var recipeList = db.Recipes.ToList();
            //foreach (var item in recipeList)
            //{
            //    foreach (var item2 in item.RecipeIngredients)
            //    {
            //        var asdas = item2.Ingredient.IngredientName;
            //    }
            //}

            return recipeList;
        }

        public Recipe GetRecipe(int Id)
        {

            Recipe recipeFound = db.Recipes.FirstOrDefault(x => x.RecipeID == Id);
            Recipe recipe = new Recipe();
            recipe = recipeFound;
            return recipe;
        }
    }
}
