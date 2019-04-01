using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // and operator
            //bool HasLicence = true;
            //bool KnowHowToDrive = false;

            //if (HasLicence == true && KnowHowToDrive == true)
            //{
            //    Console.WriteLine("You are good to go!");
            //}
            //else if (HasLicence == true && KnowHowToDrive == false)
            //{
            //    Console.WriteLine("Cheateeer!!!");
            //}
            //else if (HasLicence == false && KnowHowToDrive == true)
            //{
            //    Console.WriteLine("You need to get a licence");
            //}
            //else
            //{
            //    Console.WriteLine("That is not gonna happen pal!");
            //}

            // or operator
            bool WentForSwim = true;
            bool TookAShower = true;

            if (!WentForSwim || !TookAShower)
            {
                Console.WriteLine("Pal you are so wet");
            }
            else
            {
                Console.WriteLine("You are not wet");
            }

            // Not !
        }
    }
}
