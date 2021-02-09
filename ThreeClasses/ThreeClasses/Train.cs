using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Train
    {
        public string TypeOfTrain;//Do not know why it doesn't like this but it doesn't
        public string User_Input;
        public bool LoopBreak;//boolean variable used to break out of loops

        public Train (string TypeOfTrain)
        {
            Console.WriteLine("What type of train do you want: ");
            User_Input = Console.ReadLine();
            TypeOfTrain = User_Input; //potentially an error
            LoopBreak = false;

            while(LoopBreak == false)
            {
                if (TypeOfTrain != "electric" && TypeOfTrain != "coal")
                {
                    Console.WriteLine("Please select a type of train: ");
                    User_Input = Console.ReadLine();
                    TypeOfTrain = User_Input;
                    LoopBreak = false;

                }
                else if (TypeOfTrain == "electric")
                {
                    Console.WriteLine("You have chosen an electric train");
                    LoopBreak = true;
                }
                else if (TypeOfTrain == "coal")
                {
                    Console.WriteLine("You have chosen a coal powered train");
                    LoopBreak = true;
                }
            }
        }
    }
}
