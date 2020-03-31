using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 9;
            double div = 0;

            try
            {
                div = y / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is :" + e.Message);
            }
            finally
            {
                Console.WriteLine("Result is : " + div);
            }
        }
    }
}
