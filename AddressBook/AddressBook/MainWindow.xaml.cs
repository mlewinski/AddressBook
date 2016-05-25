using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AddressBook.Class;

namespace AddressBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (ContactContext ctx = new ContactContext())
            {
                ContactInfo[] contacts = new ContactInfo[1];
                contacts[0] = new ContactInfo() { Email = "dupa@dupa.dupa" };
                ctx.Persons.Add(new Person() {Name = "Adam", ContactInfos = contacts});
                ctx.Persons.Add(new Person() {Name = "Andrzej", ContactInfos = contacts});
                ctx.SaveChanges();
            }
        }
    }
}
