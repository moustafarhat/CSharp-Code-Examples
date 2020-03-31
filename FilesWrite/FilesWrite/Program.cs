using System.IO;

namespace FilesWrite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:\files\males");
            string file = @"C:\files\males\Names.txt";
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine("John");
            sw.WriteLine("Ahmad");

            sw.Close();
        }
    }
}