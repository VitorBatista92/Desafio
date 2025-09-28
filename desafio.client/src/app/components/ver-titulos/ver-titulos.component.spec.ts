import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerTitulosComponent } from './ver-titulos.component';

describe('VerTitulosComponent', () => {
  let component: VerTitulosComponent;
  let fixture: ComponentFixture<VerTitulosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [VerTitulosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VerTitulosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
