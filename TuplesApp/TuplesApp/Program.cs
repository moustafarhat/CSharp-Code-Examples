using System;

namespace TuplesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Jack", "William", new DateTime(2017, 10, 15), true);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString());
            Console.WriteLine(empInfo.Item5);

            var studentInfo = Tuple.Create(5, "John", "Cavin", new DateTime(2003, 10, 27));
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4);
        }
    }
}