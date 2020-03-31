using System;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dogs dog = new Dogs();
            Birds bird = new Birds();
            bird.FeedAnimal();
        }
    }

    internal class Animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnimal()
        {
        }
    }

    internal class Dogs : Animal
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToTrain;
    }

    internal class Birds : Animal
    {
        public string birdColor;
        public string birdCountry;
    }
}