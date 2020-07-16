using ChickenStore.DataAccess.Data;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenStore.DataAccess.Repository
{
    public class EmailMessageRepository : Repository<EmailMessage>, IEmailMessageRepository
    {
        private readonly ApplicationDbContext _db;

        public EmailMessageRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }

        public void Update(EmailMessage emailmessage)
        {
            var objfromdb = _db.EmailMessages.FirstOrDefault(s => s.Id == emailmessage.Id);
            if (objfromdb != null)
            {
                objfromdb.Subject = emailmessage.Subject;
                objfromdb.MessageText = emailmessage.MessageText;
                objfromdb.FromEMail = emailmessage.FromEMail;
                objfromdb.FromName = emailmessage.FromName;
                objfromdb.Resolved = emailmessage.Resolved;
                objfromdb.ResolvedBy = emailmessage.ResolvedBy;
                objfromdb.ResolvedDate = emailmessage.ResolvedDate;
                objfromdb.Sent = emailmessage.Sent;
                objfromdb.SentDate = emailmessage.SentDate;
            }
        }
    }
}
