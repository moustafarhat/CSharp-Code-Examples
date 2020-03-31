using System;

namespace NestedValueTuple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ronaldoGoals = (Year2017: 64, Year2016: 60, Year2015: 50, Year2014: 55);
            var ronaldo = (playerNo: 7, playerName: "Ronaldo", playerGoals: ronaldoGoals);

            Console.WriteLine(ronaldo.playerNo);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals.Year2017);
            Console.WriteLine(ronaldo.playerGoals.Year2016);
            Console.WriteLine(ronaldo.playerGoals.Year2015);
            Console.WriteLine(ronaldo.playerGoals.Year2014);
        }
    }
}