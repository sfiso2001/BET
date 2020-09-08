using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BET.DataAccess.Repository
{
    public class TournamentRepository : Repository<Tournament>, ITournamentRepository
    {
        private readonly ApplicationDbContext _db;

        public TournamentRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }

        public void Update(Tournament Tournament)
        {
            var objfromdb = _db.Tournaments.FirstOrDefault(s => s.TournamentID == Tournament.TournamentID);
            if (objfromdb != null)
            {
                objfromdb.TournamentName = Tournament.TournamentName;
            }
        }
    }
}
