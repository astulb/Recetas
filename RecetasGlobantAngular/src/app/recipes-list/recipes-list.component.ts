import { Component, OnInit } from '@angular/core';
import { Recipe } from '../Models/recipe';
import { RecipeService } from '../recipe.service';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.css']
})
export class RecipesListComponent implements OnInit {

  recipes: Recipe[];

  selectedRecipe : Recipe;
  constructor(private recipeService: RecipeService) 
  { 

  }

  ngOnInit(): void {
    this.getRecipes();
  }
  
  getRecipes(): void {
    this.recipeService.getRecipes()
      .subscribe(recipes => this.recipes = recipes);
  }
  onSelect(recipe: Recipe): void {
    this.selectedRecipe = recipe;
  }

  onDelete(recipeId: number): void {
    this.recipeService.deleteRecipe(recipeId);
  }

  onCreate(): void {
  }
}
