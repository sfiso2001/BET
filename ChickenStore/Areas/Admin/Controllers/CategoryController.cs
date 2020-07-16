using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChickenStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public CategoryController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if(id == null)
            {
                return View(category);
            }

            category = _unitofwork.Category.Get(id.GetValueOrDefault());

            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitofwork.Category.GetAll();
            return Json(new { data = allObj });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid)
            {
                if(category.Id ==0)
                {
                    _unitofwork.Category.Add(category);
                }
                else
                {
                    _unitofwork.Category.Update(category);                    
                }

                _unitofwork.Save();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var fromdb = _unitofwork.Category.Get(id);

            if(fromdb == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });  
            }
            else
            {
                _unitofwork.Category.Remove(fromdb);
                _unitofwork.Save();
                return Json(new { success = true, message = "Deleted" });
            }
        }

        #endregion

    }
}