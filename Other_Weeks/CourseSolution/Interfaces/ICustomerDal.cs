using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal  //Data access layer (dal)
    {

        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");

        }

        public void Update()
        {
            Console.WriteLine("Sql Update");

        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");

        }
    }
    class CustomerManager
    {

        public void Add( ICustomerDal customerDal )
        {
            customerDal.Add();
        }


    }


}
