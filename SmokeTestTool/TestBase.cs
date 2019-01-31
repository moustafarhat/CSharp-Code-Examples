using System;
using System.Collections.Generic;
using System.Text;
using SmokeTestTool.DataServices;

namespace SmokeTestTool
{
    public abstract class TestBase
    {
        public IDictionary<string, TestBase> Services;

        public TestBase()
        {
            Services = new Dictionary<string, TestBase>()
            {
                {"service1", new Service1()},
                {"service2", new Service2()}
            };
        }

        public void StartTest()
        {
            Test();
        }

        public abstract void Test();
    }
}
