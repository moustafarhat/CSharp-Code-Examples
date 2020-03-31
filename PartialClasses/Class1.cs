using System;

namespace PartialClasses
{
    partial class Animals
    {
        public string animalColor;
        public string animalName;

        public void GetName()
        {
            Console.WriteLine("My name is max, I am a dog");
        }
    }
}