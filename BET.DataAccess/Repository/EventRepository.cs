using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BET.DataAccess.Repository
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly ApplicationDbContext _db;

        public EventRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Event Event)
        {
            var objfromdb = _db.Events.FirstOrDefault(s => s.EventID == Event.EventID);
            if(objfromdb != null)
            {
                objfromdb.EventName = Event.EventName; 
                objfromdb.EventNumber = Event.EventNumber;
                objfromdb.EventDateTime = Event.EventDateTime;                
                objfromdb.EventEndDateTime = Event.EventEndDateTime;
                objfromdb.FK_TournamentId = Event.FK_TournamentId;
                objfromdb.AutoClose = Event.AutoClose;
            }
        }
    }
}
