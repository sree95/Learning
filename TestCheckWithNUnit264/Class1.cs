using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCheckWithNUnit264
{
    public class Class1
    {
        [Test]
        public void MyTestMethodOne()
        {            

            try
            {
                Assert.Fail();
            }
            catch (Exception)
            {
                Console.WriteLine("system");
            }
        }
    }
}
