using System;
using System.Collections.Generic;
using System.Text;
using BET.Models;

namespace BET.DataAccess.Repository.IRepository
{
    public interface IEventRepository : IRepository<Event>
    {
        void Update(Event Event);
    }
}
