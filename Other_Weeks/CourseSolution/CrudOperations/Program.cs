using CrudOperations.Business;
using CrudOperations.DataAccess.Concretes;
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
            CourseManager courseManager = new(new CourseDal());

            
            Course course9 = new Course();
            course9.InstructorId = 1;
            course9.Id = 8;
            course9.CategoryId = 1;
            course9.Description = string.Empty;
            course9.Title = "2025 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course9.Price = 0;
            courseManager.Add(course9);


            courseManager.Delete(2);
            List<Course> _courses = courseManager.GetAll();
            
            Console.ReadLine();

        }

   

    }
}
