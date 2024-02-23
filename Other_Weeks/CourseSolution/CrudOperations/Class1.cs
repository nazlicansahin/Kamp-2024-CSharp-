using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    internal class Class1
    {
        public class Repository<T> : IRepo<T>
        {
            private List<T> _entities = new List<T>();
            public Repository(List<T> entities)
            {
                _entities = entities;
            }

            public T GetById(int id)
            {
                return _entities.FirstOrDefault(entity => entity.Id == id);
            }

            public IEnumerable<T> GetAll()
            {
                // Gerçek implementasyon burada olacak
                throw new NotImplementedException();
            }

            public void Add(T entity)
            {
                // Gerçek implementasyon burada olacak
                throw new NotImplementedException();
            }

            public void Update(T entity)
            {
                // Gerçek implementasyon burada olacak
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                // Gerçek implementasyon burada olacak
                throw new NotImplementedException();
            }
        }

        // Course işlemleri için Repository sınıfı
        public class CourseRepository : Repository<Course>
        {
            // Özel course işlemleri burada olabilir
        }

        // Category işlemleri için Repository sınıfı
        public class CategoryRepository : Repository<Category>
        {
            // Özel category işlemleri burada olabilir
        }

        // Instructor işlemleri için Repository sınıfı
        public class InstructorRepository : Repository<Instructor>
        {
            // Özel instructor işlemleri burada olabilir
        }



    }




    //class CourseManager
    //{
    //    public void Add(Customer customer)
    //    {
    //        Console.WriteLine(customer.FirstName);
    //    }
    //    public void AddPerson(IPerson person)  //interfaci implemente eden butun classlar kullanabilir
    //    {
    //        Console.WriteLine(person.FirstName);

    //    }
    //}
}
}
