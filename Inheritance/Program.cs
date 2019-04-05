using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dogs dog = new Dogs();
            Birds bird = new Birds();
            bird.FeedAnimal();
            
        }
    }

    class Animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnimal()
        {

        }
    }

    class Dogs : Animal
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToTrain;
    }

    class Birds : Animal
    {
        public string birdColor;
        public string birdCountry;
    }
}
