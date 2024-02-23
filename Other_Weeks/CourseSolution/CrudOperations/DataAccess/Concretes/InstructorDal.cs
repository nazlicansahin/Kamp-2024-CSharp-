using CrudOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.DataAccess.Concretes
{
    internal class InstructorDal : Instructor, IRepo<Instructor>
    {
        List<Instructor> _list = new List<Instructor>();

        public void Add(Instructor entity)
        {
            _list.Add(entity);
            _list.ForEach(newEntity => Console.WriteLine(newEntity.Name));
        }

        public void Delete(int id)
        {
            Instructor ToDelete = _list.SingleOrDefault(c => c.Id == id);

            _list.Remove(ToDelete);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _list;
        }

        public Instructor GetById(int id)
        {
            var Name = _list.FirstOrDefault(c => c.Id == id);
            return Name;
        }

        public void Update(Instructor entity)
        {
            var Name = _list.FirstOrDefault(c => c.Name == entity.Name);
            if (Name != null)
            {
                Name.Name = entity.Name;
            }
        }
    }
}



