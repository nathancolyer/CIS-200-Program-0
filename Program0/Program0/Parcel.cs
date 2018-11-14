// Program 0
// CIS 200-01
// Due: 9/11/2017
// ID: C2518

// An abstract class for the Parcel object which includes an origin and destination.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        private Address _originAddress; //origin adress backing field.
        private Address _destinationAddress; //destination address backing field.

        //Precondition: None
        //Postcondition: parcel is created with origin and destination zip.
        public Parcel(Address origAddress, Address destAddress)
        {
            OriginAddress = origAddress;
            DestinationAddress = destAddress;
        }

        public Address OriginAddress
        {
            //Pre: none
            //Post:Returns origin address
            get
            {
                return _originAddress;
            }
            //Pre: none
            //Post: sets specified origin address value
            set
            {
                _originAddress = value;
            }
        }

        public Address DestinationAddress
        {
            //Pre: none
            //Post:Returns origin address
            get
            {
                return _destinationAddress;
            }
            //Pre: none
            //Post:sets specified destination address vale
            set
            {
                _destinationAddress = value;
            }
        }

        //provides common definition for derived classes
        public abstract decimal CalcCost();

        //Pre: none
        //Post: returns Parcel string data
        public override string ToString()
        {
            return $"Origin: {OriginAddress}\n" +
                $"Destination: {DestinationAddress}\n" +
                $"Cost: {CalcCost():c}\n";
        }
    }
}
