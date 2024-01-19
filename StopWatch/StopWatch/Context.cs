using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Context : Istate
    {
        public string TextFirstButton1  { get { return TextFirstButton;  } set { TextFirstButton = "Start"; } } // => throw new NotImplementedException(); 
        //to github
        public string TextSecondButton2 { get { return TextFirstButton; } set { TextFirstButton = "Lapping"; } }//=> throw new NotImplementedException();
        public string State = "inital";
        public string TextFirstButton = "Start";
        public string TextSecondButton = "Lapping";
        public Istate PressFirstButton()
        {
            if (TextFirstButton == "Start" && TextSecondButton == "Lapping")
            {
                Console.WriteLine("StopWatch Started");
                State = "Running";
                Running();
            }
            else if (TextFirstButton == "Stop" && TextSecondButton == "Lapping" && State == "Running")
            {
                Console.WriteLine("StopWatch Stop");
                State = "Display";
                DisplayResultState();
            }
            else if (TextFirstButton == "Stop" && TextSecondButton == "Lapping" )
            {

                Console.WriteLine("StopWatch Stop");
                State = "Display";
                DisplayResultState();
            }
            else if (TextFirstButton == "Start" && TextSecondButton == "Reset")
            {Console.WriteLine("StopWatch Restarted");
                State = "Running";
                Running();
            }
            
            return this;

        }

        public Istate PressSecondButton()
        {
            if (TextFirstButton == "Start" && TextSecondButton == "Lapping")
            {
                Console.WriteLine($"CurrentStage[{State}],Button1[{TextFirstButton}],,Button1[{TextSecondButton}]");
                State = "Inital";
                // Running();
            }
            else if (TextFirstButton == "Stop" && TextSecondButton == "Lapping" && (State == "Running" || State == "Lapping"))
            {

                Console.WriteLine("StopWatch Lapped");
                State = "Lapping";
                LappingState();
            }
            else if (TextFirstButton == "Stop" && TextSecondButton == "Lapping" )
            {
                Console.WriteLine("StopWatch Lapped");
                State = "Running";
                LappingState();
            }
            
            else if (TextFirstButton == "Start" && TextSecondButton == "Reset")
            {
                Console.WriteLine("StopWatch Reset");
                State = "Initial";
                Initial();
            }
            
            return this;
        }

       public void Initial()
        {
            TextFirstButton = "Start";
            TextSecondButton = "Lapping";
            Console.WriteLine($"CurrentStage[{State}],Button1[{TextFirstButton}],Button1[{TextSecondButton}]");        
        }
        public void Running()
        {         
            TextFirstButton = "Stop";
            TextSecondButton = "Lapping";
            Console.WriteLine($"CurrentStage[{State}],Button1[{TextFirstButton}],Button1[{TextSecondButton}]");
        }
        public void LappingState()
        {
            TextFirstButton = "Stop";
            TextSecondButton = "Lapping";
            Console.WriteLine($"CurrentStage[{State}],Button1[{TextFirstButton}],Button1[{TextSecondButton}]");
        }
        public void DisplayResultState()
        {
            TextFirstButton = "Start";
            TextSecondButton = "Reset";
            Console.WriteLine($"CurrentStage[{State}],Button1[{TextFirstButton}],Button1[{TextSecondButton}]");
          

        }





    }
}
