using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EFPeople
{
    class Context: DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
