using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NUnitLearning
{
    [TestFixture]
    class Program
    {
        StringBuilder sb;

       [SetUp]
        public void MyFixTestMethod()
        {
            sb = new StringBuilder();
        }


        [Test]
        public void MyTestMethodTwo()
        {
            sb.Append("Line1");
            sb.Append("\nLine2");
            Console.WriteLine(sb.ToString());
        }
        
        [Test]
        public void MyTestMethod()
        {
            sb.Append("Line1");
            sb.Append("\nLine2");
            sb.Append("\nLine3");
            Console.WriteLine(sb.ToString());
        }

        [TearDown]
        public void MyTearTestMethod()
        {
            sb = null;
        }
    }
}
