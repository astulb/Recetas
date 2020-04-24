using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Model
{
    public class RecipeModel
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string Difficulty { get; set; }

        public List<IngredientModel> Ingredients { get; set; }

        public RecipeModel(int id, string name, string dif, List<RecipeIngredient> ings)
        {
            RecipeID = id;
            RecipeName = name;
            Difficulty = dif;

            Ingredients = new List<IngredientModel>();
            foreach (var item in ings)
            {
                var toAdd = new IngredientModel(item.Ingredient.IngredientName, item.IngredientID);
                Ingredients.Add(toAdd);

            }
        }
    }
}
