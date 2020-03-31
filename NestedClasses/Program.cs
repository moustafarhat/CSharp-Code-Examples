namespace NestedClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animals animal = new Animals();
            Animals.Dogs dog = new Animals.Dogs();
            Animals.Cats cat = new Animals.Cats();
        }
    }

    internal class Animals
    {
        public string animalName;
        public string animalCountry;

        public class Dogs
        {
            public string dogBreed;
            public string dogNickname;
        }

        public class Cats
        {
            public string catName;
        }
    }
}