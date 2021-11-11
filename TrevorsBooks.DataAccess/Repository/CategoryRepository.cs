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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object
            //then pass the id as a generic entity which matches the category ID
            var objFromDB = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDB != null)
            {
                //save changes if not null
                objFromDB.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
