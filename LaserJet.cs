﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer is printing. . . . ");
        }
    }
}
