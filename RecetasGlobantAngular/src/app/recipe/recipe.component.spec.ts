import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeComponent } from './recipe.component';

//COMENTARIOS
//describe: Un texto que describe la prueba y se muestra en los resultados
describe('SE ESPERA QUE SE CREE EL COMPONENTE', () => {
  let component: RecipeComponent;
  let fixture: ComponentFixture<RecipeComponent>;
//BEFOREEACH
//Se ejecuta antes de cada una de las pruebas
//permite crear un entorno independiente, encapsulado y realista
//de la aplicacion. En este bloque se encuentra la variable "component"
//que es una instancia del componente que se va a examinar
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecipeComponent ] //PAQUETE DEL COMPONENTE
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
//IT
//ESTA ES LA PRUEBA, ESTA COMPUESTA POR LA DESCRIPCION DE LO QUE 
//SE EVALUA Y EL CODIGO QUE SE EJECUTA PARA EXAMINAR UN ELEMENTO O CONDUCTA
  it('FUNCIONA...CREA EL COMPONENTE', () => {
    expect(component).toBeTruthy();
  });
});
