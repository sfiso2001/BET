using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BET.DataAccess.Repository
{
    public class EventDetailRepository : Repository<EventDetail>, IEventDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public EventDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(EventDetail Event)
        {
            var objfromdb = _db.EventDetails.FirstOrDefault(s => s.EventDetailID == Event.EventDetailID);
            if (objfromdb != null)
            {
                objfromdb.EventDetailName = Event.EventDetailName;
                objfromdb.EventDetailNumber = Event.EventDetailNumber;
                objfromdb.EventDetailOdd = Event.EventDetailOdd;
                objfromdb.EventDetailStatus = Event.EventDetailStatus;
                objfromdb.FK_EventDetailStatusID = Event.FK_EventDetailStatusID;
                objfromdb.FK_EventId = Event.FK_EventId;
                objfromdb.FinishingPosition = Event.FinishingPosition;
                objfromdb.FirstTimer = Event.FirstTimer;
            }
        }
    }
}
