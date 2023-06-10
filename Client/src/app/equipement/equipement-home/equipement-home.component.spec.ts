import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EquipementHomeComponent } from './equipement-home.component';

describe('EquipementHomeComponent', () => {
  let component: EquipementHomeComponent;
  let fixture: ComponentFixture<EquipementHomeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EquipementHomeComponent]
    });
    fixture = TestBed.createComponent(EquipementHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
