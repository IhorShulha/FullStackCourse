using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Address
    {
        int index;
        int house;
        int apartment;

        string country;
        string city;
        string street;

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                if (value > 0)
                {
                    index = value;
                }
            }
        }
        
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value > 0)
                {
                    house = value;
                }
            }
        }

        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

        public string Country { get; set; }
        public string City { get; set; } 
        public string Street { get; set; }

    }
}
