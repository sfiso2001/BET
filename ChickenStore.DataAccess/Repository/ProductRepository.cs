using ChickenStore.DataAccess.Data;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product product)
        {
            var objfromdb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if(objfromdb != null)
            {
                if(product.ImageUrl!=null)
                {
                    objfromdb.ImageUrl = product.ImageUrl;                        
                }

                objfromdb.Name = product.Name; 
                objfromdb.Description = product.Description;
                objfromdb.Price = product.Price;                
                objfromdb.Unit = product.Unit;
                objfromdb.CategoryId = product.CategoryId;  
            }
        }
    }
}
