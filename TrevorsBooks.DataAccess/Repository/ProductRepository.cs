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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            //use .NET LINQ to retrieve the first or default category object
            //then pass the id as a generic entity which matches the category ID
            var objFromDB = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDB != null)
            {
                //save changes if not null
                if (product.ImageUrl != null)
                {
                    objFromDB.ImageUrl = product.ImageUrl; //add the check for image url
                }
                objFromDB.Title = product.Title;
                objFromDB.Description = product.Description;
                objFromDB.ISBN = product.ISBN;
                objFromDB.Author = product.Author;
                objFromDB.ListPrice = product.ListPrice;
                objFromDB.CategoryId = product.CategoryId;
                objFromDB.CoverTypeId = product.CoverTypeId;
                //all props of Product object
            }
        }
    }
}
