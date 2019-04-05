using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string name = "Daniel";

        static void Main(string[] args)
        {
            SayHi();
        }

        static void SayHi()
        {
            name = "Jon";
            Console.WriteLine("Hi, " + name);
        }
    }
}
