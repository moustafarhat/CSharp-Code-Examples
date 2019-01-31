using System;
using System.Collections.Generic;
using System.Text;
using SmokeTestTool.DataServices;

namespace SmokeTestTool
{
    public class Initalizer
    {
        private readonly TestBase _testBase=new Service1();

        private Initalizer() { }

            public void DoWork()
            {
                _testBase.StartTest();
            }

            // You can call this static method which calls the singleton instance method.
            public static void DoSomeWork()
            {
                Instance.DoWork();
            }

            public static Initalizer Instance
            {
                get { return instance; }
            }

            private static Initalizer instance = new Initalizer();
        }
    
}
