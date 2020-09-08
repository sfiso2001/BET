import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EventdetailsstatusComponent } from './eventdetailsstatus.component';

describe('EventdetailsstatusComponent', () => {
  let component: EventdetailsstatusComponent;
  let fixture: ComponentFixture<EventdetailsstatusComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EventdetailsstatusComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EventdetailsstatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
