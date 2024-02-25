using CrudOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.DataAccess.Concretes
{

    public class CourseDal : Course, IRepo<Course>
    {


        List<Course> _list = new List<Course>();

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.InstructorId = 1;
            course1.Id = 1;
            course1.CategoryId = 1;
            course1.Description = string.Empty;
            course1.Price = 0;
            


            Course course2 = new Course();
            course2.Title = "Silindi Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.InstructorId = 1;
            course2.Id = 2;
            course2.CategoryId = 1;
            course2.Description = string.Empty;
            course2.Price = 0;

            Course course3 = new Course();
            course3.Title = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course3.InstructorId = 1;
            course3.Id = 3;
            course3.CategoryId = 1;
            course3.Description = string.Empty;
            course3.Price = 0;

            Course course4 = new Course();
            course4.Title = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course4.InstructorId = 1;
            course4.Id = 4;
            course4.CategoryId = 1;
            course4.Description = string.Empty;
            course4.Price = 0;

            Course course5 = new Course();
            course5.Title = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course5.InstructorId = 1;
            course5.Id = 5;
            course5.CategoryId = 1;
            course5.Description = string.Empty;
            course5.Price = 0;

            Course course6 = new Course();
            course6.Title = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course6.InstructorId = 2;
            course6.Id = 6;
            course6.CategoryId = 1;
            course6.Description = string.Empty;
            course6.Price = 0;

            Course course7 = new Course();
            course7.Title = "Programlamaya Giriş için Temel Kurs";
            course7.InstructorId = 1;
            course7.Id = 7;
            course7.CategoryId = 1;
            course7.Description = string.Empty;
            course7.Price = 0;

            Course course8 = new Course();
            course8.Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course8.InstructorId = 1;
            course8.Id = 8;
            course8.CategoryId = 1;
            course8.Description = string.Empty;
            course8.Price = 0;

            _list = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };
        }

        public void Add(Course entity)
        {
            _list.Add(entity);
            _list.ForEach(newEntity => Console.WriteLine(newEntity.Title));
        }

        public void Delete(int id)
        {
            Course ToDelete = _list.FirstOrDefault(c => c.Id == id);

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




