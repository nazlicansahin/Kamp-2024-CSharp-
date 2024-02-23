using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CrudOperations.Program;

namespace CrudOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category()
            {
                Name = "Test",
                Id = 1,
                Description = "Test",
            };

        }

   

    }
    //class Crud : IRepo<IEntity>
    //{

    //    List<IEntity> _categories = new List<IEntity>();


    //    public void Add(IEntity entity)
    //    {
    //        _categories.Add(entity);
    //        _categories.ForEach(category => Console.WriteLine(category.Id));
    //    }

    //    //public void CategoryAdd(Category entity)
    //    //{
    //    //    _categories.Add(entity);
    //    //    _categories.ForEach(category => Console.WriteLine(category.Name));

    //    //}

  

    //    //public void CategoryDelete(int id)
    //    //{
    //    //    Category categoriesToDelete = _categories.SingleOrDefault(c => c.Id == id);

    //    //    _categories.Remove(categoriesToDelete);
    //    //}

    //    public IEnumerable<IEntity> GetAll()
    //    {
    //        return _categories;

    //    }

    //    public Category GetCategoryById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UpdateCategory(Category entity)
    //    {
    //        var categoryName = _categories.FirstOrDefault(c => c.Name == entity.Name);
    //        if (categoryName != null)
    //        {
    //            categoryName.Name = entity.Name;
    //        }
    //    }

    //    public void Update(IEntity entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    //IEnumerable<IEntity> IRepo<IEntity>.GetAll()
    //    //{
    //    //    throw new NotImplementedException();
    //    //}

    //    IEntity IRepo<IEntity>.GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        IEntity categoriesToDelete = _categories.SingleOrDefault(c => c.Id == id);

    //        _categories.Remove(categoriesToDelete);
    //    }
    //}
}
