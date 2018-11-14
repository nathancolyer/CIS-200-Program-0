// Program 0
// CIS 200-01
// Due: 9/11/2017
// ID: C2518

//A dervived letter class from the base parcel class. Contains origin and destination class as well as fixed cost.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel
    {
        private decimal _fixedCost; //backing field for fixed cost
        //Precondition:Fixed cost must be > 0
        // Postcondition: A letter is created with values from origin and destination address from the base Address class and fixed cost.
        public Letter(Address origAddress, Address destAddress, decimal fixedCost): base(origAddress, destAddress)
        {
            if (fixedCost > 0)
                _fixedCost = fixedCost;
            else
                throw new ArgumentOutOfRangeException("Invalid cost");
        }
        
        //Pre: None
        //Post: fixed cost is returned
        public override decimal CalcCost()
        {
            return _fixedCost;
        }

        //Pre: None
        //Post: String with the Letter data returned
        public override string ToString()
        {
            return $"Origin: {OriginAddress}\n\n" +
                $"Destination: {DestinationAddress}\n\n" +
                $"Cost: {CalcCost():c}\n\n";
        }
    }
}
