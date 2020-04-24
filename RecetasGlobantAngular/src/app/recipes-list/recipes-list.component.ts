import { Component, OnInit } from '@angular/core';
import { RECIPES } from '../mock-recipes';
import { Recipe } from '../Models/recipe';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.css']
})
export class RecipesListComponent implements OnInit {

  title="A VER SI ESTO FUNCIONA"

  recipes = RECIPES;

  selectedRecipe : Recipe;
  constructor() { }

  ngOnInit(): void {
  }

  onSelect(recipe: Recipe): void {
    this.selectedRecipe = recipe;
  }

  onDelte(recipe: Recipe): void {
  }

  onCreate(): void {
  }

  

}
