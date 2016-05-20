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
    public class Int32ExtensionsTests
    {
        [TestMethod()]
        public void IsBetween_Will_ReturnTrue_WhenValue_LessThanLower_AndGreaterThanUpper()
            => Assert.IsTrue(3.IsBetween(2, 4));

        [TestMethod]
        public void IsBetween_Will_ReturnFalse_WhenValue_EqualToLowerBoundary()
            => Assert.IsFalse(3.IsBetween(3, 5));
        
        [TestMethod]
        public void IsBetween_Will_ReturnFalse_WhenValue_EqualToUpperBoundary()
            => Assert.IsFalse(3.IsBetween(1, 3));

        [TestMethod()]
        public void IsBetweenInclusive_Will_ReturnTrue_WhenValue_LessThanLower_AndGreaterThanUpper()
            => Assert.IsTrue(3.IsBetweenInclusive(2, 4));

        [TestMethod]
        public void IsBetween_Inclusive_Will_ReturnTrue_WhenValue_EqualToLowerBoundary()
            => Assert.IsTrue(3.IsBetweenInclusive(3, 5));

        [TestMethod]
        public void IsBetween_Inclusive_Will_ReturnTrue_WhenValue_EqualToUpperBoundary()
            => Assert.IsTrue(3.IsBetweenInclusive(1, 3));

        [TestMethod]
        public void IsBetween_Inclusive_Will_ReturnFalse_WhenValue_LessThanLowerBoundary()
            => Assert.IsFalse(3.IsBetweenInclusive(4, 6));

        [TestMethod]
        public void IsBetween_Inclusive_Will_ReturnFalse_WhenValue_GreaterThanUpperBoundary()
            => Assert.IsFalse(3.IsBetweenInclusive(0, 2));
    }
}