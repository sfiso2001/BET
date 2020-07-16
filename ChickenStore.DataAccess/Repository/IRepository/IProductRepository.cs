using System;
using System.Collections.Generic;
using System.Text;
using ChickenStore.Models;

namespace ChickenStore.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product Product);
    }
}
