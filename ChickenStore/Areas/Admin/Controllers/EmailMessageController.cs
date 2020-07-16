using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChickenStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailMessageController : Controller
    {        
        private readonly IUnitOfWork _unitofwork;

        public EmailMessageController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            EmailMessage emailmessage = new EmailMessage();                
            return View(emailmessage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmailMessage emailmessage)
        {
            if (ModelState.IsValid)
            {
                if (emailmessage.Id == 0)
                {
                    _unitofwork.EmailMessage.Add(emailmessage);
                }
                else
                {
                    _unitofwork.EmailMessage.Update(emailmessage);
                }

                _unitofwork.Save();

                if(emailmessage.Id > 0)                    
                {
                    if (SendMessage(emailmessage))                
                    {
                        emailmessage.Sent = true;
                        emailmessage.SentDate = DateTime.Now;

                        _unitofwork.EmailMessage.Update(emailmessage);
                        _unitofwork.Save();
                    }
                }

                return View("MessageSuccess");
            }

            return View(emailmessage);
        }

        private bool SendMessage(EmailMessage emailmessage)
        {
            bool sent = false;
            emailer _emailer = new emailer();

            //load emailsetup
            var emailsetup = _unitofwork.EmailSetup.GetFirstOrDefault();
            if(emailsetup != null)
            {
                sent = _emailer.SendEmail(emailmessage, emailsetup);
            }

            return sent;
        }
    }
}
