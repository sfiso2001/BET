using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BET.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private bool disposedValue;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;     
            SP_Call = new SP_Call(_db);
            Tournament = new TournamentRepository(_db);
            Event = new EventRepository(_db);
            EventDetail = new EventDetailRepository(_db);
            EventDetailStatus = new EventDetailStatusRepository(_db);
        }

        public ISP_Call SP_Call { get; }
        public ITournamentRepository Tournament { get; }
        public IEventRepository Event { get; }
        public IEventDetailRepository EventDetail { get; }
        public IEventDetailStatusRepository EventDetailStatus { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
