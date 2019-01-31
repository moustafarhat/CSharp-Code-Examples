using System;

namespace SmokeTestTool
{
    class Program
    {
        private readonly TestBase _testBase;

        public Program(TestBase testBase)
        {
            this._testBase = testBase;
        }

 
         static void Main(string[] args)
         {
             
            Initalizer.DoSomeWork();
        }
    }
}
