using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    class Train
    {
        private string TypeOfTrain;


        public bool LoopBreak;//boolean variable used to break out of loops

        public string Train_Type { get => TypeOfTrain; set => TypeOfTrain = value; }
        

        public Train (string TypeOfTrain)
        {
            
            LoopBreak = false;

            while(LoopBreak == false)
            {
                if (TypeOfTrain != "electric" && TypeOfTrain != "coal")
                {
                    Console.WriteLine("Please select a type of train: ");
                    
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
