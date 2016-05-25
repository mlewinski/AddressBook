﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Class
{
    public class Person
    {
        public Person() { }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Address> Addresses { get; set; } 
        public virtual ICollection<ContactInfo> ContactInfos { get; set; } 
    }
}
