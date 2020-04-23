using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//Meli
namespace RecipesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        IRecipeBL _recipeBL;
        public RecipesController(IRecipeBL recipeBL)
        {
            _recipeBL = recipeBL;
        }

        [HttpGet]
        public IEnumerable<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            return recipes; 
        }

        [HttpGet]
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            return ingredients;
        }

        [HttpPost]
        public void AddRecipe(Recipe recipe)
        {
           // _recipeBL.Add(recipe);
        }

        [HttpPut]
        public void DeleteRecipe(int recipeId)
        {
            // _recipeBL.DeleteRecipe(recipeID);
        }
    }
}
