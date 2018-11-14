// Program 0
// CIS 200-01
// Due: 9/11/2017
// ID: C2518

// Class that models an address. It includes name, address1, address2, city, state, and zip code.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        //backing fields
        private string _name; //name on the address
        private string _addressLine1; //address line for street address
        private string _addressLine2; // 2nd address line for apartment or building no.
        private string _city; //city on address
        private string _state; //state on address
        private int _zip; //zip code on address

        public const int MIN_ZIP = 00000; //minimum value for zip code
        public const int MAX_ZIP = 99999; // maximum value for zip code

        //Precondition: zip<=MAX_ZIP, zip>=MIN_ZIP
        //Postcondition: Address is created with specified values of name, address1, address2, city, state, and zip.
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            //Properties to ensure validation
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }

        //Precondition: zip<=MAX_ZIP, zip>=MIN_ZIP
        //Postcondition: Address is created with specified values of name, address1, city, state, and zip.
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }

        public string Name
        {
            //pre: none
            //post: Name is returned
            get
            {
                return _name;
            }
            //pre: must contain string value.
            //post: sets name to specified value.
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Name is invalid");
                else
                    _name = value;

            }
        }

        public string Address1
        {
            get
            {
                return _addressLine1;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Address1 is invalid");
                else
                    _addressLine1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return _addressLine2;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Address2 is invalid");
                else
                    _addressLine2 = value;
            }
        }

        public string City
        {
            //pre: none
            //post: city is returned
            get
            {
                return _city;
            }
            //pre: must contain string value
            //post: sets city value for address
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("City is invalid");
                else
                    _city = value;
            }

        }

        public string State
        {
            //pre: none
            //post: returns state value
            get
            {
                return _state;
            }
            //pre: must have string value
            //post: sets state value for address
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("State is invalid");
                else
                    _state = value;
            }
        }

        public int Zip
        {
            //pre: none
            //post: returns zip value
            get
            {
                return _zip;
            }
            //pre: zip value must be >=MIN and <=MAX
            //post: sets zip value for address
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                {
                    _zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Zip must be 00000-99999");
                }
            }
        }

        //Pre: None
        //Post: String with address data is returned
        public override string ToString()
        {
           if (Address2 != null) //If address2 is not null, do not include adderss2 data
                
           return $"{Name}\n" + $"{Address1}\n" +
                  $"{Address2}\n" +$"{City}" + ", " +
                  $"{State}" + " " + $"{Zip}";
           //else, do not include address2 in data
            return $"{Name}\n" + $"{Address1}\n" +
                   $"{City}" + ", " +
                   $"{State}" + " " + $"{Zip}";   
                                 
        }

    }
}
