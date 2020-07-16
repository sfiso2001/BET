using ChickenStore.DataAccess.Data;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objfromdb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objfromdb != null)
            {
                objfromdb.Name = category.Name;
            }
        }
    }
}
