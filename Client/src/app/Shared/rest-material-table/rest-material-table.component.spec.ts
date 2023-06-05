import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestMaterialTableComponent } from './rest-material-table.component';

describe('RestMaterialTableComponent', () => {
  let component: RestMaterialTableComponent;
  let fixture: ComponentFixture<RestMaterialTableComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RestMaterialTableComponent]
    });
    fixture = TestBed.createComponent(RestMaterialTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
