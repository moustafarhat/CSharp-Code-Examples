using System;

namespace FilesRead
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string file = @"c:\files\names.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File ended");
            sr.Close();
        }
    }
}