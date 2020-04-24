using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipesAPI.Model;

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
        public IEnumerable<RecipeModel> GetAllRecipes()
        {
            //_recipeBL.AddStuffIfDBEmpty();
            List<RecipeModel> toReturn = new List<RecipeModel>();
            var recipesDB = _recipeBL.GetAllRecipes();
            foreach (var item in recipesDB)
            {
                toReturn.Add(new RecipeModel(item.RecipeID, item.RecipeName, item.Difficulty, item.RecipeIngredients.ToList()));
            }
            return toReturn;
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
        public void AddRecipe([FromBody]Recipe recipe)
        {
            _recipeBL.AddRecipe(recipe);
        }

        [HttpDelete]
        [Route("{recipeId}")]
        public void DeleteRecipe(int recipeId)
        {
            _recipeBL.DeleteRecipe(recipeId);
        }
    }
}
