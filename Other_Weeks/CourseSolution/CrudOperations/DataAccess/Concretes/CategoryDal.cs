using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.DataAccess.Concretes
{
    internal class CategoryDal : Category, IRepo<Category>
    {
        List<Category> _categories = new List<Category>();

        public void Add(Category entity)
        {
            _categories.Add(entity);
            _categories.ForEach(category => Console.WriteLine(category.Name));

        }

        public void Delete(int id)
        {
            Category categoriesToDelete = _categories.SingleOrDefault(c => c.Id == id );

            _categories.Remove(categoriesToDelete);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories;

        }

        public Category GetById(int id)
        {
            var categoryName = _categories.FirstOrDefault(c => c.Id== id);
            return categoryName;
        }

        public void Update(Category entity)
        {
            var categoryName = _categories.FirstOrDefault(c => c.Name == entity.Name);
            if (categoryName != null)
            {
                categoryName.Name = entity.Name;
            }
        }
    }
}
