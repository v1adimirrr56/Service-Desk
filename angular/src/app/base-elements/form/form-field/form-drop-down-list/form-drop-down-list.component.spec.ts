import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormDropDownListComponent } from './form-drop-down-list.component';

describe('FormSelectComponent', () => {
  let component: FormDropDownListComponent;
  let fixture: ComponentFixture<FormDropDownListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormDropDownListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormDropDownListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
