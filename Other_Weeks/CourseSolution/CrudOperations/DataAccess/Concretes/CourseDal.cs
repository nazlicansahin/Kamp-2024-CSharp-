using CrudOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.DataAccess.Concretes
{

    internal class CourseDal : Course, IRepo<Course>
    {
    
        List<Course> _list = new List<Course>();
        public void Add(Course entity)
        {
            _list.Add(entity);
            _list.ForEach(newEntity => Console.WriteLine(newEntity.Title));
        }

        public void Delete(int id)
        {
            Course ToDelete = _list.SingleOrDefault(c => c.Id == id);

            _list.Remove(ToDelete);
        }

        public IEnumerable<Course> GetAll()
        {
            return _list;

        }

        public Course GetById(int id)
        {
            var Name = _list.FirstOrDefault(c => c.Id == id);
            return Name;
        }

        public void Update(Course entity)
        {
            var Name = _list.FirstOrDefault(c => c.Title == entity.Title);
            if (Name != null)
            {
                Name.Title = entity.Title;
            }
        }
    }
}




