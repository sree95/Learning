using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParallelExecution
{
    public class DependsOnResults
    {
        public TestStatus tStatus ;

        [Test]
        public void TestOne1()
        {
            Console.WriteLine("TestOne");
            
        }

        [Test]
        public void TestTwo2()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                Console.WriteLine("Test2");
            }            
        }
    }
}
