using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Passenger
    {
        private string FirstName; //creates private string FirstName
        private string LastName; //creates private string LastName

        public string First_Name { get => FirstName; set => FirstName = value; }
        public string Last_Name { get => LastName; set => LastName = value; }

        public Passenger(string First_Name = null, string Last_Name = null) //creates method with First_Name and Last_Name as parameters
        {
            //FirstName = First_Name;
            //LastName = Last_Name;
            Console.WriteLine("Customer " + First_Name + " " + Last_Name); //writes customers first and last name to the console

        }
    }
}
