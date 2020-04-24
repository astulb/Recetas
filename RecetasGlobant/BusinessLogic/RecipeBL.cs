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

        public void AddStuffIfDBEmpty()
        {
            if(_recipeRepository.GetAllRecipes().Count == 0)
            {
                Recipe aRecipe = new Recipe()
                {
                    Difficulty = "ez",
                    RecipeName = "tacos",
                    RecipeIngredients = new List<RecipeIngredient>()

                };

                Ingredient ing1 = new Ingredient()
                {
                    IngredientName = "papa",
                    RecipeIngredients = new List<RecipeIngredient>()
                };
                Ingredient ing2 = new Ingredient()
                {
                    IngredientName = "arroz",
                    RecipeIngredients = new List<RecipeIngredient>()
                }; 
                Ingredient ing3 = new Ingredient()
                {
                    IngredientName = "manteca",
                    RecipeIngredients = new List<RecipeIngredient>()
                };

                RecipeIngredient rec1 = new RecipeIngredient()
                {
                    Recipe = aRecipe,
                    Ingredient = ing1
                };
                RecipeIngredient rec2 = new RecipeIngredient()
                {
                    Recipe = aRecipe,
                    Ingredient = ing2
                };
                RecipeIngredient rec3 = new RecipeIngredient()
                {
                    Recipe = aRecipe,
                    Ingredient = ing3
                };

                aRecipe.RecipeIngredients.Add(rec1);
                aRecipe.RecipeIngredients.Add(rec2);
                aRecipe.RecipeIngredients.Add(rec3);

                ing1.RecipeIngredients.Add(rec1);
                ing2.RecipeIngredients.Add(rec2);
                ing3.RecipeIngredients.Add(rec3);


                _recipeRepository.AddRecipe(aRecipe);

            }
        }
    }
}
