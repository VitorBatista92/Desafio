import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarTituloComponent } from './listar-titulo.component';

describe('ListarTituloComponent', () => {
  let component: ListarTituloComponent;
  let fixture: ComponentFixture<ListarTituloComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListarTituloComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarTituloComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
