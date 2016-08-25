using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelExecution
{
    public class Class2
    {
        [Parallelizable]
        [Test]
        public void TestMethod2()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Parallel Test Two");
        }
    }
}
