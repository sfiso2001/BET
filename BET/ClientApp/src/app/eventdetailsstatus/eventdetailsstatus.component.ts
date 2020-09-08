import { Component, OnInit } from '@angular/core';
import { EventDetailsStatusModel, EventDetailsStatusService } from '../../Services/eventdetailsstatus.service';

@Component({
  selector: 'app-eventdetailsstatus',
  templateUrl: './eventdetailsstatus.component.html',
  styleUrls: ['./eventdetailsstatus.component.css']
})
export class EventdetailsstatusComponent implements OnInit {

  public statslist: EventDetailsStatusModel;

  constructor(private serviceEventDetailsStatus: EventDetailsStatusService) { }

  ngOnInit() {
  }

  getAllEventDetailsSatatuses() {
    this.serviceEventDetailsStatus.getalleventdetailsstatus().subscribe(data=>this.statslist= data);
  }

}
