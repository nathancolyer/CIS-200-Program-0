// Program 0
// CIS 200-01
// Due: 9/11/2017
// ID: C2518

//Console application that displays the origin zip, destination zip, and fixed cost for an
// number of various addresses.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            //test data for different addresses
            var Address1 = new Address("Papa John", "1234 Pizza Way", "Louisville", "KY", 40216);
            var Address2 = new Address("Andrew Wright", "1111 Cardinal Blvd", "Louisville", "KY", 40222);
            var Address3 = new Address("John Smith", "1255 Doctor Way", "Apt #100", "Nashville", "TN", 60621);
            var Address4 = new Address("Mr. Programmer", "200 CIS Dr", "Apt #300", "New York", "NY",77011);
            //test data for different letters
            var Letter1 = new Letter(Address1, Address2, 4.00m);
            var Letter2 = new Letter(Address3, Address4, 10.00m);
            var Letter3 = new Letter(Address1, Address3, 150.00m);

            var ParcelList = new List<Parcel>(); //List of parcels 
       
            ParcelList.Add(Letter1); //adds letters to list
            ParcelList.Add(Letter2); 
            ParcelList.Add(Letter3); 

            //displays all letters in list
            foreach(var Letter in ParcelList)
            {
                Console.Write($"{Letter.ToString()}");
            }
            
        }
    }
}
