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
            return _recipeBL.GetAllRecipes();
        }
        
        [HttpGet]
        [Route("ingredients")]
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _recipeBL.GetAllIngredients();
        }

        [HttpGet]
        [Route("recipe/{recipeId:int}")]
        public Recipe GetRecipe(int recipeId)
        {
            return _recipeBL.GetRecipe(recipeId);
        }

        [HttpPost]
        public void AddRecipe(Recipe recipe)
        {
            _recipeBL.AddRecipe(recipe);
        }

        [HttpDelete]
        [Route("{recipeId:int}")]
        public void DeleteRecipe(int recipeId)
        {
            _recipeBL.DeleteRecipe(recipeId);
        }
    }
}
