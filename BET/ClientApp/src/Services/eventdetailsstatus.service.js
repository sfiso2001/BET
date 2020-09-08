"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.EventDetailsStatusModel = exports.EventDetailsStatusService = void 0;
var core_1 = require("@angular/core");
var EventDetailsStatusService = /** @class */ (function () {
    function EventDetailsStatusService(httpobj, _baseurl) {
        this.httpobj = httpobj;
        this.appurl = "";
        this.appurl = _baseurl;
    }
    EventDetailsStatusService.prototype.getalleventdetailsstatus = function () {
        return this.httpobj.get(this.appurl + "api/EventDetailsStatus/Index");
    };
    EventDetailsStatusService = __decorate([
        __param(1, core_1.Inject('BASE_URL'))
    ], EventDetailsStatusService);
    return EventDetailsStatusService;
}());
exports.EventDetailsStatusService = EventDetailsStatusService;
var EventDetailsStatusModel = /** @class */ (function () {
    function EventDetailsStatusModel() {
    }
    return EventDetailsStatusModel;
}());
exports.EventDetailsStatusModel = EventDetailsStatusModel;
//# sourceMappingURL=eventdetailsstatus.service.js.map