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

            List<Course> _courses = courseManager.GetAll();
            for (int i = 0; i < _courses.Count; i++)
            {
                Console.WriteLine(_courses[i].Title + "  Eğitmen: " + _courses[i].InstructorId);
            }

            Console.WriteLine();
            Console.WriteLine();

        //    InstructorManager instructorManager = new(new InstructorDal());

        //    List<Instructor> _instructor = instructorManager.GetAll();
        //    for (int i = 0; i < _instructor.Count; i++)
        //    {
        //        Console.WriteLine(_instructor[i].FirstName + " " + _instructor[i].LastName);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine();

        //    CategoryManager categoryManager = new(new CategoryDal());

        //    List<Category> _category = categoryManager.GetAll();
        //    for (int i = 0; i < _category.Count; i++)
        //    {
        //        Console.WriteLine(_category[i].CategoryName);
        //    }
        }

   

    }
}
