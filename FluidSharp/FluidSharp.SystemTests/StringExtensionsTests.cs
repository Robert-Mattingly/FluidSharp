using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluidSharp.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void After_Will_ReturnSplit_WhenCalledOnBananaSplit_AndPassed6()
            => Assert.AreEqual("Split", "BananaSplit".After(6));

        [TestMethod]
        public void After_will_ReturnSameString_WhenPassed_CharsToSkipEqualTo0()
            => Assert.AreEqual("BananaSplit", "BananaSplit".After(0));

        [TestMethod]
        public void After_will_ReturnEmptyString_WhenPassed_CharsToSkipLessThan0()
            => Assert.AreEqual(String.Empty, "BananaSplit".After(-1));
        
        [TestMethod]
        public void After_will_ReturnEmptyString_WhenPassed_CharsToSkiGreaterThanStringLength()
            => Assert.AreEqual(String.Empty, "BananaSplit".After(12));
    }
}