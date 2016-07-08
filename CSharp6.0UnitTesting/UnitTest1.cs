using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp6._0;

namespace CSharp6._0UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserCreatesID()
        {
            var one = new UserOne();
            Assert.AreEqual(Guid.Empty, one.Id);
        }

    }
}
