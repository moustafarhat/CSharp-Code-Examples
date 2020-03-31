namespace MethodDescription
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dogs max = new Dogs();
            max.Sit();
        }
    }

    /// <summary>
    /// DogCommands will be the interface for the methods to be applied
    /// </summary>
    internal interface DogCommands
    {
        void Sit();

        void Sit(string dogName, string trainerName);
    }

    /// <summary>
    /// Class Animal will be a base class for the child classes like Dogs
    /// </summary>
    internal class Animal
    {
    }

    internal class Dogs : Animal, DogCommands
    {
        /// <summary>
        /// Sit method will make the dog sit
        /// </summary>
        public void Sit()
        {
        }

        /// <summary>
        ///  Overloaded method will take two parameters of type string
        /// </summary>
        /// <param name="dogName">string used to hold the dog name</param>
        /// <param name="trainerName">string used to hold the trainer name</param>
        public void Sit(string dogName, string trainerName)
        {
        }
    }
}