using ChickenStore.DataAccess.Data;
using ChickenStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private bool disposedValue;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            EmailMessage = new EmailMessageRepository(_db);
            EmailSetup = new EmailSetupRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; }
        public IProductRepository Product { get; }
        public ICompanyRepository Company { get; set; }
        public IApplicationUserRepository ApplicationUser { get; set; }
        public IEmailMessageRepository EmailMessage { get; set; }
        public IEmailSetupRepository EmailSetup { get; set; }
        public ISP_Call SP_Call { get; }

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
