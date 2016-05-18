using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluidSharp.System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FluidSharp.System.Data.SqlClient.Tests
{
    [TestClass()]
    public class DataTableExtensionsTests
    {
        [TestMethod()]
        public void WithColumn_Will_AddTheProvidedColumn_ToTheDataTable()
        {
            var columnToAdd = new DataColumn("NewColumn");

            var tableToReceiveColumn = new DataTable();

            var tableWithColumn = tableToReceiveColumn.WithColumn(columnToAdd);

            Assert.ReferenceEquals(columnToAdd, tableWithColumn.Columns[0]);
        }
    }
}