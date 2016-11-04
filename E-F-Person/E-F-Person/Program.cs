using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_F_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PersonContext())
            {
                Person pers = new Person() { Name = "New Person", Age = 21 };

                ctx.Persons.Add(pers);
                ctx.SaveChanges();
            }
        }
    }
}
