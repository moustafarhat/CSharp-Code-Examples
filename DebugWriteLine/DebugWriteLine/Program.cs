using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DebugWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Debug.WriteLine("Hello from the debug writeline");
            Debug.WriteLineIf(x == 50,"X = " + x);
            Debug.WriteLine("Y = " + y);
            x = 50;
            y = 100;
            Debug.WriteLineIf(x == 50, "X = " + x);
            Debug.WriteLine("Y = " + y);
            Debug.WriteLine("Program has been terminated");
        }
    }
}
