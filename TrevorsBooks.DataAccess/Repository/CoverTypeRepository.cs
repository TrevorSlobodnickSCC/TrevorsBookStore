using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrevorsBooks.DataAccess.Repository.IRepository;
using TrevorsBooks.Models;
using TrevorsBooks.DataAccess.Data;

namespace TrevorsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //use .NET LINQ to retrieve the first or default category object
            //then pass the id as a generic entity which matches the category ID
            var objFromDB = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDB != null)
            {
                //save changes if not null
                objFromDB.Name = category.Name;
            }
        }
    }
}
