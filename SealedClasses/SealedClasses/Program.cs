namespace SealedClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dogs dog = new Dogs();
        }
    }

    internal sealed class Animal
    {
        public string name;
    }

    internal class Dogs : Animal // you will need to remove the sealed keyword in order for inheritance to work
    {
        public string dogBreed;
    }
}