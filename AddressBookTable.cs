using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AddressBookLinQ
{
    class AddressBookTable
    {
        //Retrive All Records
        DataTable dataTable = new DataTable();

        

        public void createAddressBookTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Rows.Add("Arti", "Dandge", "Ashish Plaza", "Pune", "MH", 763222, 9876543210, "asd@gmail.com");
            dataTable.Rows.Add("Champa", "Magar", "Venu Hights", "Pune", "MH", 763222, 933343210, "rohit@gmail.com");
            dataTable.Rows.Add("Neha", "Sharma", "Flex Road", "Mumbai", "MH", 403222, 6776543210, "neha@gmail.com");
            dataTable.Rows.Add("Preeti", "Neghi", "Neer Road", "Benglore", "Karnataka", 40002, 999000880, "preeti@gmail.com");
            dataTable.Rows.Add("Dameto", "Swami", "Panji", "Panaji", "Goa", 43254, 7777743210, "asd@gmail.com");
            dataTable.Rows.Add("Rama", "Magare", "Indor", "Indor", "MP", 43254, 7877743990, "Rama@gmail.com");
            dataTable.Rows.Add("Rekha", "Swami", "baroda", "Baroda", "MP", 43254, 7888743210, "rekha@gmail.com");

        }
        public void displayAddressBook()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("\nFirstName:-" + row.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + row.Field<string>("LastName"));
                Console.WriteLine("Address:-" + row.Field<string>("Address"));
                Console.WriteLine("City:-" + row.Field<string>("City"));
                Console.WriteLine("State:-" + row.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + row.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + row.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + row.Field<string>("Email"));
            }
        }
    }
}
