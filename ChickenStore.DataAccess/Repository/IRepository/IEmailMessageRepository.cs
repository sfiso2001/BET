using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenStore.DataAccess.Repository.IRepository
{
    public interface IEmailMessageRepository : IRepository<EmailMessage>
    {
        void Update(EmailMessage emailmessage);
    }
}
