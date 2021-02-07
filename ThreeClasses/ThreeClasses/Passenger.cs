using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Passenger
    {
        public string FirstName; //creates public string FirstName
        public string LastName; //creates public string LastName

        public Passenger(string First_Name = null, string Last_Name = null) //creates method with First_Name and Last_Name as parameters
        {
            FirstName = First_Name;
            LastName = Last_Name;
            Console.WriteLine("Customer " + First_Name + Last_Name); //writes customers first and last name to the console

        }
    }
}
