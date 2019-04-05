using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            
        }
    }

    sealed class Animal
    {
        public string name;
    }

    class Dogs : Animal // you will need to remove the sealed keyword in order for inheritance to work
    {
        public string dogBreed;

    }
}
