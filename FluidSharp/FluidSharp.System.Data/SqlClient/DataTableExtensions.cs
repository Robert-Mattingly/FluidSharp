using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System.Data.SqlClient
{
    /// <summary>
    /// A collection of methods to ease interactions with DataTable objects.
    /// </summary>
    public static class DataTableExtensions
    {
        /// <summary>
        /// Creates a new DataRow object matching the DataTable's schema and adds it to the DataRowCollection object.
        /// </summary>
        /// <param name="table">The DataTable to receive the created DataRow.</param>
        /// <returns>System.Data.DataTable containing the created DataRow.</returns>
        public static DataRow AddNewRow(this DataTable table)
        {
            var newRow = table.NewRow();
            table.Rows.Add(newRow);
            return newRow;
        }

        /// <summary>
        /// Creates and adds a new DataColumn object to the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to receive the created DataColumn.</param>
        /// <returns>System.Data.DataTable containing the created DataColumn.</returns>
        public static DataTable WithColumn(this DataTable table)
        {
            table.Columns.Add();
            return table;
        }

        /// <summary>
        /// Adds the provided DataColumn to the DataTable's DataColumnCollection.
        /// </summary>
        /// <param name="table">The DataTable to receive the column.</param>
        /// <param name="column">The DataColumn to add to the DataTable.</param>
        /// <returns>System.Data.DataTable containing the provided DataColumn.</returns>
        public static DataTable WithColumn(this DataTable table, DataColumn column)
        {
            table.Columns.Add(column);
            return table;
        }

        /// <summary>
        /// Creates a new DataColumn and adds it to the DataTable's DataColumnCollection.
        /// </summary>
        /// <param name="table">The DataTable to receive the created DataColumn.</param>
        /// <param name="columnName">The name to assign to the DataColumn's ColumnName property.</param>
        /// <returns>System.Data.DataTable containing the created DataColumn.</returns>
        public static DataTable WithColumn(this DataTable table, string columnName)
        {
            table.Columns.Add(columnName);
            return table;
        }
        

        /// <summary>
        /// Creates a new DataColumn and adds it to the DataTable's DataColumnCollection.
        /// </summary>
        /// <param name="table">The DataTable to receive the created DataColumn.</param>
        /// <param name="columnName">The name to assign to the created DataColumn's ColumnName property.</param>
        /// <param name="type">The Type to assign to the created DataColumn's DataType property.</param>
        /// <returns>System.Data.DataTable containing the created DataColumn.</returns>
        public static DataTable WithColumn(this DataTable table, string columnName, Type type)
        {
            table.Columns.Add(columnName, type);
            return table;
        }

        /// <summary>
        /// Creates a new DataColumn and adds it to the DataTable's DataColumnCollection.
        /// </summary>
        /// <param name="table">The DataTable to receive the created DataColumn.</param>
        /// <param name="columnName">The name to assign to the created DataColumn's ColumnName property.</param>
        /// <param name="type">The Type to assign to the created DataColumn's DataType property.</param>
        /// <param name="expression">The string expression to assign to the created DataColumn's Expression property.  
        /// (e.g. To create a column which sums the value of the Hourly and OverTime columns, "Hourly + OverTime".)</param>
        /// <returns>System.Data.DataTable containing the created DataColumn.</returns>
        /// <remarks>
        /// For more information on using the Expression property, please review the 
        /// MSDN documentation at https://msdn.microsoft.com/en-us/library/system.data.datacolumn.expression%28v=vs.110%29.aspx.
        /// </remarks>
        public static DataTable WithColumn(this DataTable table, string columnName, Type type, string expression)
        {
            table.Columns.Add(columnName, type, expression);
            return table;
        }
    }
}
