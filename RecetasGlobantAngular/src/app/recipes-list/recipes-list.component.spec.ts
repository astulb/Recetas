import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipesListComponent } from './recipes-list.component';



describe('SE ESPERA QUE CREE LA LISTA Y TITULO', () => {
  let component: RecipesListComponent;
  let fixture: ComponentFixture<RecipesListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecipesListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecipesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('FUNCIONA...CREA LA LISTA', () => {
    expect(component).toBeTruthy();
  });

  it(`DEBERIA TENER EL TITULO 'A VER SI ESTO FUNCIONA'`, () => {
    const fixture=TestBed.createComponent(RecipesListComponent);
    const app=fixture.debugElement.componentInstance;
    expect(app.title).toEqual('A VER SI ESTO FUNCIONA')
  });
});
