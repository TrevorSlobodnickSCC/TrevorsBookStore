using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrevorsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); //retrieve a cat from the database by id
        //List of cats based on requirements
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null //useful for foreign key refs
            );
        void Add(T entity); //add an entity
        void Remove(int id); //remove an object or category
        void Remove(T entity); //another way to remove an object
        void RemoveRange(IEnumerable<T> entity); //removes a range of entities

    }
}
