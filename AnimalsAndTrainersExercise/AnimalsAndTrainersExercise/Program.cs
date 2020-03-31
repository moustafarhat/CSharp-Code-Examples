using System;
using System.Collections;

namespace AnimalsAndTrainersExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animals dog = new Animals { Name = "Max" };

            Animals cat = new Animals { Name = "Lucy" };

            Animals elephant = new Animals { Name = "Fofy" };

            Trainers john = new Trainers { TrainerName = "John Jackson" };

            ArrayList list = new ArrayList { dog, cat, elephant, john };

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else
                {
                    ((Trainers)item).SayHi();
                }
            }
        }
    }

    internal struct Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eating");
        }
    }

    internal struct Trainers
    {
        public string TrainerName { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hello I am the new trainer");
        }
    }
}