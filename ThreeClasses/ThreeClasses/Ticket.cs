using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Ticket : Passenger
    {
        public int NumberOfTickets; //create constructor for variable
        public string TypeOfTicket; //create constructor for variable
        public bool Switch;
        

        public Ticket(int NumberOfTickets,string TypeOfTicket)
        {
            Console.WriteLine("How many tickets do you want: ");
            NumberOfTickets = int.Parse(Console.ReadLine());

            while (NumberOfTickets < 1)
            {
                if (NumberOfTickets == 0)
                {
                    Console.WriteLine("Please enter a higher number: ");
                    int v = int.Parse(Console.ReadLine());
                    NumberOfTickets = v;

                }
                else
                {
                    Console.WriteLine("You want " + NumberOfTickets + "tickets");
                    break;

                }
            }

            Console.WriteLine("What type of ticket do you want");
            TypeOfTicket = Console.ReadLine();

            while (Switch == false)
            {
                if (TypeOfTicket != "first class" || TypeOfTicket != "business")
                {
                    Console.WriteLine("Please enter a ticket type: ");
                    TypeOfTicket = Console.ReadLine();
                    Switch = false;
                }
                else if (TypeOfTicket == "first class")
                {
                    Console.WriteLine("You have selected first class");
                    Switch = true;
                }
                else if (TypeOfTicket == "business")
                {
                    Console.WriteLine("You have selected business");
                    Switch = true;
                }
            }

            


        }
    }
}
