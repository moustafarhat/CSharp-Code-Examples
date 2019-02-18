using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmokeTestTool.DataServices;

namespace SmokeTestTool
{
    public abstract class TestBase
    {
        public IDictionary<string, TestBase> Services = new Dictionary<string, TestBase>()
        {
            {"service1", new Service1()},
            {"service2", new Service2()}
        };

       public IEnumerable<ICollection<TestBase>> GetNewService()
        {
            return Services.Select(variable => Services.Values);
        }

        public void StartTest()
        {
            Test();
        }

        public abstract void Test();
    }
}
