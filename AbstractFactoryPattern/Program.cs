using System;
using AbstractFactoryPattern.Example1;
using AbstractFactoryPattern.Example1.interfaces;
using AbstractFactoryPattern.Example1.Nokia;
using AbstractFactoryPattern.Example1.Samsung;

namespace AbstractFactoryPattern
{
    public static class Program
    {
        static void Main()
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            var nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            var samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }
    }
 
}

