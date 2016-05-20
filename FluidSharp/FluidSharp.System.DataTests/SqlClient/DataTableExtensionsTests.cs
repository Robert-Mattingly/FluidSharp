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
        [TestMethod]
        public void AddNewRow_Will_AddARowToTheDataTable()
        {
            var table = new DataTable();

            table.AddNewRow();

            Assert.AreEqual(1, table.Rows.Count);
        }

        [TestMethod]
        public void AddNewRow_Will_CreateARowWithTheSameSchema_AsTheDataTable()
        {
            var table = new DataTable().WithColumn("Name").WithColumn("Age");

            var row = table.AddNewRow();

            Assert.AreEqual(2, row.ItemArray.Length);
        }

        [TestMethod]
        public void AddNewRow_Will_ReturnTheCreatedRow()
        {
            var table = new DataTable();

            var newRow = table.AddNewRow();

            Assert.ReferenceEquals(table.Rows[0], newRow);
        }

        [TestMethod]
        public void WithColumn_Will_AddACreatedColumn_ToTheDataTable()
            => Assert.AreEqual(1, new DataTable().WithColumn().Columns.Count);

        [TestMethod]
        public void WithColumn_Will_ReturnTheSameDataTable()
        {
            var originalTable = new DataTable();

            var tableWithColumn = originalTable.WithColumn();

            Assert.ReferenceEquals(originalTable, tableWithColumn);
        }

        [TestMethod()]
        public void WithColumn_Will_AddTheProvidedColumn_ToTheDataTable()
        {
            var columnToAdd = new DataColumn("NewColumn");

            var tableToReceiveColumn = new DataTable();

            var tableWithColumn = tableToReceiveColumn.WithColumn(columnToAdd);

            Assert.ReferenceEquals(columnToAdd, tableWithColumn.Columns[0]);
        }

        [TestMethod]
        public void WithColumn_Will_ReturnTheSameDataTable_WhenPassedDataColumn()
        {
            var columnToAdd = new DataColumn("NewColumn");

            var originalTable = new DataTable();

            var tableWithColumn = originalTable.WithColumn(columnToAdd);

            Assert.ReferenceEquals(originalTable, tableWithColumn);
        }

        [TestMethod()]
        public void WithColumn_Will_AddTheCreatedColumn_WithTheProvidedColumnName_ToTheDataTable()
            => Assert.AreEqual("NewColumn", new DataTable().WithColumn("NewColumn").Columns[0].ColumnName);

        [TestMethod]
        public void WithColumn_Will_ReturnTheSameDataTable_WhenPassedColumnName()
        {
            var originalTable = new DataTable();

            var tableWithColumn = originalTable.WithColumn("NewColumn");

            Assert.ReferenceEquals(originalTable, tableWithColumn);
        }

        [TestMethod()]
        public void WithColumn_Will_AddTheCreatedColumn_WithTheProvidedColumnNameAndType_ToTheDataTable()
        {
            var expectedValues = new Tuple<string, Type>("NewColumn", typeof(int));

            var table = new DataTable().WithColumn("NewColumn", typeof(int));

            var resultantValues = new Tuple<string, Type>(table.Columns[0].ColumnName, table.Columns[0].DataType);

            Assert.AreEqual(expectedValues, resultantValues);
        }

        [TestMethod]
        public void WithColumn_Will_ReturnTheSameDataTable_WhenPassedColumnNameAndType()
        {
            var originalTable = new DataTable();

            var tableWithColumn = originalTable.WithColumn("NewColumn", typeof(int));

            Assert.ReferenceEquals(originalTable, tableWithColumn);
        }

        [TestMethod()]
        public void WithColumn_Will_AddTheCreatedColumn_WithTheProvidedColumnNameAndTypeAndExpression_ToTheDataTable()
        {
            var expectedValues = new Tuple<string, Type, string>("NewColumn", typeof(int), "Hourly + OverTime");

            var table = new DataTable().WithColumn("Hourly")
                                       .WithColumn("OverTime")
                                       .WithColumn("NewColumn", typeof(int), "Hourly + OverTime");

            var resultantValues = new Tuple<string, Type, string>(table.Columns[2].ColumnName, table.Columns[2].DataType, table.Columns[2].Expression);

            Assert.AreEqual(expectedValues, resultantValues);
        }

        [TestMethod]
        public void WithColumn_Will_ReturnTheSameDataTable_WhenPassedColumnNameAndTypeAndExpression()
        {
            var originalTable = new DataTable();

            var tableWithColumn = originalTable.WithColumn("Hourly")
                                               .WithColumn("OverTime")
                                               .WithColumn("NewColumn", typeof(int), "Hourly + OverTime");

            Assert.ReferenceEquals(originalTable, tableWithColumn);
        }
    }
}