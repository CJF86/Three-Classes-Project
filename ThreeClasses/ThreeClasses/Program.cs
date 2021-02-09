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

            Passenger john = new Passenger("John", " Cena"); //creates passenger named john cena using passenger method/class

            Console.WriteLine("how many tickets do you want");

            int TicketAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("What type of ticket do you want");

            string TicketType = Console.ReadLine(); //Do not know why this is triggering the passenger method


            Ticket newobj = new Ticket(TicketAmount, TicketType); //not using these values but requiring them to run

            Console.ReadLine();
            
        }
    }
}
