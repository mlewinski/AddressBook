using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Class
{
    public class ContactInfo
    {
        public ContactInfo() { }
        public int ContactInfoId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }

        public virtual ICollection<Person> Persons { get; set; } 
    }
}
