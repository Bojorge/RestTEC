import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SetdishComponent } from './setdish.component';

describe('SetdishComponent', () => {
  let component: SetdishComponent;
  let fixture: ComponentFixture<SetdishComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SetdishComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SetdishComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
