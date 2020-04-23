using System;
using System.Collections.Generic;
using System.Text;

//Gianni
namespace Domain
{
    public class Ingredient
    {
        public int IngredientID { get; set; }

        public string IngredientName { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

    }
}
