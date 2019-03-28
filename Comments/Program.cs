using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is " + double_num + " float is " + 
                float_num + " decimal is " + decimal_num);

            string firstName, lastName, House;
            firstName = "Jon";
            lastName = " Snow";
            House = "Stark";


            //Console.Write("Hello, " + firstName + lastName + " of House Stark");

            bool IsWorking;

            IsWorking = true;

            Console.WriteLine(IsWorking);

            int sum;
            sum = 0;

            int number1, number2;

            number1 = 5;
            number2 = 100;
            sum = number2;
            Console.WriteLine(sum);
        }
    }
}
