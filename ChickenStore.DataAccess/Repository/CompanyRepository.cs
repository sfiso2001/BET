using ChickenStore.DataAccess.Data;
using ChickenStore.DataAccess.Repository.IRepository;
using ChickenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenStore.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Company company)
        {
            var objfromdb = _db.Companies.FirstOrDefault(s => s.Id == company.Id);
            if (objfromdb != null)
            {
                objfromdb.Name = company.Name;
                objfromdb.StreetAddress = company.StreetAddress;
                objfromdb.City = company.City;
                objfromdb.State = company.State;
                objfromdb.PostalCode = company.PostalCode;
                objfromdb.PhoneNumber = company.PhoneNumber;
                objfromdb.IsAuthorisedCompany = company.IsAuthorisedCompany;
            }
        }
    }
}
