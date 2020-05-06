using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension");
        }
        public void Print()
        {
            Console.WriteLine("The printer is printing. . . . ");
        }
    }
}
