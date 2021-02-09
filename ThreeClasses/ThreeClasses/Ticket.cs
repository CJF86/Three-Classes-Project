﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Ticket //: Program //removing inheritance from passenger prevents triggering of passenger method
    {
        private int NumberOfTickets; //switching to private
        private string TypeOfTicket; //switching to private
        public bool Switch;
        public int TicketAmount { get => NumberOfTickets; set => NumberOfTickets = value; }
        public string TicketType { get => TypeOfTicket; set => TypeOfTicket = value; }
        public Ticket(int NumberOfTickets,string TypeOfTicket)
        {
            //NumberOfTickets = TicketAmount; //Creates constructor for NumberOfTickets
            //TypeOfTicket = TicketType; //Creates constructor for TypeOfTicket

            Console.WriteLine("How many tickets do you want: ");
            NumberOfTickets = int.Parse(Console.ReadLine()); //needs to be able to handle exceptions

            while (Switch == false)
            {
                if (NumberOfTickets == 0)
                {
                    Console.WriteLine("Please enter a higher number: ");
                    int v = int.Parse(Console.ReadLine());
                    NumberOfTickets = v;
                    Switch = false;

                }
                else
                {
                    Console.WriteLine("You want " + NumberOfTickets + " tickets");
                    Switch = true;
                    break;
                }
            }

            Console.WriteLine("What type of ticket do you want");
            TypeOfTicket = Console.ReadLine();
            Switch = false;

            //Switch is set to true which does not trigger the while loop

            while (Switch == false)
            {
                if (TypeOfTicket != "first class" && TypeOfTicket != "business")
                {
                    Console.WriteLine("Please enter a valid ticket type: ");
                    TypeOfTicket = Console.ReadLine();
                    Switch = false;
                }
                else if (TypeOfTicket == "first class")
                {
                    Console.WriteLine("You have selected first class");
                    Switch = true;
                    break;
                }
                else if (TypeOfTicket == "business")
                {
                    Console.WriteLine("You have selected business");
                    Switch = true;
                    break;
                }

            }

        }
        //public int TicketAmount { get; }
        //public string TicketType { get; }

    }
}
