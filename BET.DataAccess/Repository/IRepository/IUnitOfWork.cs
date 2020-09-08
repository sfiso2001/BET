using System;
using System.Collections.Generic;
using System.Text;

namespace BET.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISP_Call SP_Call { get; }

        ITournamentRepository Tournament { get; }
        IEventRepository Event { get; }
        IEventDetailRepository EventDetail { get; }

        IEventDetailStatusRepository EventDetailStatus { get; }

        void Save();
    }
}
