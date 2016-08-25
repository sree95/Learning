using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace ParallelExecution
{
    public class Class1
    {
        [Parallelizable]
        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Parallel Test One");
        }
    }
}
