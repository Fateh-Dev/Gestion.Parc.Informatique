import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HierarchicalComponent } from './hierarchical.component';

describe('HierarchicalComponent', () => {
  let component: HierarchicalComponent;
  let fixture: ComponentFixture<HierarchicalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HierarchicalComponent]
    });
    fixture = TestBed.createComponent(HierarchicalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
