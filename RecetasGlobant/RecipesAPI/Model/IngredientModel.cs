using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Model
{
    public class IngredientModel
    {
        public string IngredientName { get; set; }

        public int IngredientID { get; set; }

        public IngredientModel(string Name, int Id)
        {
            IngredientName = Name;
            IngredientID = Id;
        }
    }
}
