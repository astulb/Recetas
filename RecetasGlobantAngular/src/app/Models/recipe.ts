import { Ingredient } from './ingredient';

export interface Recipe {
    recipeID: number;
    recipeName: string;
    difficulty: string;
    ingredients: Ingredient[];
  }