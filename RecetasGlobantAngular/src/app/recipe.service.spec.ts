import { TestBed } from '@angular/core/testing';

import { RecipeService } from './recipe.service';

describe('DESPLEGA LA LISTA DE ALIMENTOS???', () => {
  let service: RecipeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RecipeService);
  });

  it('SI LA DESPLEGA', () => {
    expect(service).toBeTruthy();
  });
});
