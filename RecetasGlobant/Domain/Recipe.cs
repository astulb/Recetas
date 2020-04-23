using System;
using System.Collections.Generic;

//Gianni
namespace Domain
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        public string RecipeName { get; set; }

        public string Difficulty { get; set; }
        
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }

}
