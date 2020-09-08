using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BET.DataAccess.Repository
{
    public class EventDetailStatusRepository : Repository<EventDetailStatus>, IEventDetailStatusRepository
    {
        private readonly ApplicationDbContext _db;

        public EventDetailStatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(EventDetailStatus EventDetailStatus)
        {
            var objfromdb = _db.EventDetailStatuses.FirstOrDefault(s => s.EventDetailStatusID == EventDetailStatus.EventDetailStatusID);
            if(objfromdb != null)
            {
                objfromdb.EventDetailStatusName = EventDetailStatus.EventDetailStatusName; 
            }
        }
    }
}
