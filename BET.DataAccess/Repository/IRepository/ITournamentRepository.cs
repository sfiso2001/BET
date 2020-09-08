using BET.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BET.DataAccess.Repository.IRepository
{
    public interface ITournamentRepository : IRepository<Tournament>
    {
        void Update(Tournament tournament);
    }
}
