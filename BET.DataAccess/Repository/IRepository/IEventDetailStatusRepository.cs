using System;
using System.Collections.Generic;
using System.Text;
using BET.Models;

namespace BET.DataAccess.Repository.IRepository
{
    public interface IEventDetailStatusRepository : IRepository<EventDetailStatus>
    {
        void Update(EventDetailStatus eventDetailStatus);
    }
}
