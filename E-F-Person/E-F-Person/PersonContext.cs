using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_F_Person
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base()
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
