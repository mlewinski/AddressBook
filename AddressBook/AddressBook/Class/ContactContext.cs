using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Class
{
    class ContactContext : DbContext
    {
        public ContactContext() : base() { }
        public DbSet<Person> Persons { get; set; }
    }
}
