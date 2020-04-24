import { Injectable } from '@angular/core';
import { Recipe } from './Models/recipe';
import { RECIPES } from './mock-recipes';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import 'rxjs/add/operator/do'
import 'rxjs/add/operator/catch';


@Injectable({
  providedIn: 'root'
})
export class RecipeService {

  private recipesUrl = "http://localhost:22742/recipes";

  constructor(
    private http: HttpClient
  ) { }

  getRecipes(): Observable<Recipe[]> {
    return this.http.get<Recipe[]>(this.recipesUrl)
    .do( res => console.log('HTTP response:', res))
    .catch(this.handleError);
  }

  private deleteURL = "http://localhost:22742/recipes/6";


  deleteRecipe(recipeId: number): Observable<{}> {
    return this.http.delete(this.deleteURL)
  }

  private handleError(err: HttpErrorResponse) { 
    console.log(err.message);
    return Observable.throw(err.message);        
  }
}
