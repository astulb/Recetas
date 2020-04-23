using DataAccess;
using Domain;
using System;
using System.Collections.Generic;

//Meli
namespace BusinessLogic
{
    public class RecipeBL : IRecipeBL
    {
        IRecipeRepository _recipeRepository;
        public RecipeBL(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public ICollection<Recipe> GetAllRecipes()
        {
            return _recipeRepository.GetAllRecipes();
        }

        public ICollection<Ingredient> GetAllIngredients()
        {
            return _recipeRepository.GetAllIngredients();
        }

        public Recipe GetRecipe(int recipeId)
        {
            return _recipeRepository.GetRecipe(recipeId);
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipeRepository.AddRecipe(recipe);
        } 

        public void DeleteRecipe(int recipeId)
        {
            _recipeRepository.DeleteRecipe(recipeId);
        }
  
    }
}
