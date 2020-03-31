using System;

namespace ValueTuplesWithMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ronaldo = (7, "Ronaldo", 60);
            var giggs = (10, "Giggs", 40);

            DisplayPlayerInformation(ronaldo);
            DisplayPlayerInformation(giggs);

            DisplayPlayerInformation(DisplayPlayerInformation());
        }

        public static void DisplayPlayerInformation((int playerNo, string playerName, int playerGoal) player)
        {
            Console.WriteLine(player.playerNo);
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerGoal);
            Console.WriteLine("-------------------");
        }

        public static (int, string, int) DisplayPlayerInformation()
        {
            var messi = (10, "Messi", 60);
            return messi;
        }
    }
}