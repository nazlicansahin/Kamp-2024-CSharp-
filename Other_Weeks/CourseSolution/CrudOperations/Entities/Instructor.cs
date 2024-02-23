using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    public class Instructor : IEntity
    {

            public string Name { get; set; }
            public string Bio { get; set; }
        public int Id { get ; set ; }
    }
}
