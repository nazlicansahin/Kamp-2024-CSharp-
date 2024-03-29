﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName= "Engin"},
                new Student{FirstName= "Derin"},
                new Person{FirstName= "Salih"},
            };
            foreach (var person in persons) {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();


    }
            class Person
        {
            public string FirstName { get; set; }
            public int Id { get; set; }

            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string City { get; set; }

        }

        class Student : Person
        {
            public string Department { get; set; }
        }
        }
}
