using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
