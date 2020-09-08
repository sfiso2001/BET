using System;
using System.Collections.Generic;
using System.Text;
using BET.Models;

namespace BET.DataAccess.Repository.IRepository
{
    public interface IEventDetailRepository : IRepository<EventDetail>
    {
        void Update(EventDetail eventDetail);
    }
}
