import { HttpClient } from "@angular/common/http";
import { inject, Inject } from "@angular/core";
import { Observable } from "rxjs";

export class EventDetailsStatusService {
  appurl: string = "";


  constructor(private httpobj: HttpClient, @Inject('BASE_URL') _baseurl: string) {
    this.appurl = _baseurl;
  }

  getalleventdetailsstatus(): Observable<EventDetailsStatusModel> {
    return this.httpobj.get<EventDetailsStatusModel>(this.appurl + "api/EventDetailsStatus/Index");
  }

}

export class EventDetailsStatusModel {
  EventDetailStatusID: number;
  EventDetailStatusName: string;
}
