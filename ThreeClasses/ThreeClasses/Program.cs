using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //code needs to be able to handle exceptions

            Passenger john = new Passenger("John", " Cena"); //creates passenger named john cena using passenger method/class

            Console.WriteLine("Please enter your first name: ");

            string First_Name = Console.ReadLine(); 

            Console.WriteLine("Please enter your last name: ");

            string Last_Name = Console.ReadLine(); 

            Passenger newobj1 = new Passenger(First_Name, Last_Name); //creates passenger class instance

            Console.WriteLine("how many tickets do you want");

            int TicketAmount = int.Parse(Console.ReadLine()); 

            Console.WriteLine("What type of ticket do you want");

            string TicketType = Console.ReadLine(); 

            Ticket newobj = new Ticket(TicketAmount, TicketType); //creates ticket class instance

            Console.WriteLine("What type of train do you want: ");

            string Train_Type = Console.ReadLine();

            Train newobj2 = new Train(Train_Type); //creates train class instance

            Console.ReadLine();
            
        }
    }
}
