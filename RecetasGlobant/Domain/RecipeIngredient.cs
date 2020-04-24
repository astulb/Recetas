using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class RecipeIngredient
    {
            public int RecipeID { get; set; }

            public virtual Recipe Recipe { get; set; }

            public int IngredientID { get; set; }

            public virtual Ingredient Ingredient { get; set; }

    }
}
