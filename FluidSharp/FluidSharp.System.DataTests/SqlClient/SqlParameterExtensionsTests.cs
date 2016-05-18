using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluidSharp.System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FluidSharp.System.Data.SqlClient.Tests
{
    [TestClass()]
    public class SqlParameterExtensionsTests
    {
        [TestMethod()]
        public void WithValue_Will_ReturnTheSameSqlParameter()
        {
            var param = new SqlParameter();

            var paramWithValue = param.WithValue(4);

            Assert.ReferenceEquals(param, paramWithValue);
        }

        [TestMethod]
        public void WithValue_Will_SetTheSqlParametersValue_ToThePassedValue()
        {
            var param = new SqlParameter().WithValue("TestValue");

            Assert.AreEqual("TestValue", param.Value);
        }
    }
}