using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using BET.DataAccess.Data;
using BET.DataAccess.Repository.IRepository;
using BET.Models;
using Microsoft.AspNetCore.Mvc;

namespace BET.Controllers
{
    public class EventDetailsStatusController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public EventDetailsStatusController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        [Route("api/EventDetailsStatus/Index")]
        public IEnumerable<EventDetailStatus> GetEventDetailStatuses()
        {
            return _unitofwork.EventDetailStatus.GetAll();
        }
    }
}
