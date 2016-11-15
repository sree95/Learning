using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelExecution
{
    public class MultipleAsserts
    {
        [Test]
        public void MyTestMethod()
        {

            Assert.That
                (
                    2 == 2 && 2 != 3
                );
                       
            TestContext.Write("TestCase failed due to this error");
            //var err = TestContext.Error;
            //Console.WriteLine(err);
        }

    }
}
