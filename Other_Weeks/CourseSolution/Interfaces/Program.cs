using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            //Diyelim ki iki verin var ve sen bunu iki farklı servera eklemek istiyorsun
            ICustomerDal[] customerDals = new ICustomerDal[2]
            { new OracleServerCustomerDal(), 
              new SqlServerCustomerDal() 
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 2, FirstName = "Nazli", LastName = "Sahin", Adress = "Ëskisehir" };
            personManager.Add(customer);
        }
    }
    interface IPerson
    {
        int Id { get; set; } 
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id {get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }


    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
        public void AddPerson(IPerson person)  //interfaci implemente eden butun classlar kullanabilir
        {
            Console.WriteLine(person.FirstName);

        }
    }
}
