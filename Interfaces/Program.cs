using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();
            
        }
    }

    public interface IAnimals
    {
        void Run();
    }

    public interface IDogCommands : IAnimals
    {
        void Stay();
        void Sit();
        void Attack();

        string DogName
        {
            set;
            get;
        }
    }

    interface Trainer
    {

    }

    class Animals
    {
        string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class");
        }
    }

    class Dogs : Animals, IDogCommands, Trainer
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is staying");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is attacking");
        }

        public void Run()
        {
            Console.WriteLine("Animal is running");
        }

        public string DogName { get; set; }
    }
}
