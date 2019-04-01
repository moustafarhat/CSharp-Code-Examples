using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool username = false;
            bool email = false;
            bool password = true;

            if ((username || email) && password)
                Console.WriteLine("User is valid.");
            else
                Console.WriteLine("Something went wrong");
        }
    }
}
