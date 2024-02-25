using CrudOperations.DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Business
{
    internal class CourseManager : CourseDal

    {


        private readonly CourseDal _courseDal;

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course courses)
        {
            _courseDal.Add(courses);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return (List<Course>)_courseDal.GetAll();
        }

        public void Update(Course courses)
        {
            _courseDal.Update(courses);
        }
    }
}

    
