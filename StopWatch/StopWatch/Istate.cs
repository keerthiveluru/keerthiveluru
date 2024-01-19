using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal interface Istate
    {
       string TextFirstButton1 { get; set; }
        string TextSecondButton2 { get; set; }

        Istate PressFirstButton();
        Istate PressSecondButton();
    }
}
