using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IEmailMessageRepository EmailMessage { get; }
        IEmailSetupRepository EmailSetup { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
