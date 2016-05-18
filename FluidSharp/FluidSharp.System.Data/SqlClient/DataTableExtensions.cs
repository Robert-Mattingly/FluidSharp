using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System.Data.SqlClient
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// Adds the provided DataColumn to the DataTable's DataColumnCollection, returning the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to receive the column.</param>
        /// <param name="column">The DataColumn to add to the DataTable.</param>
        /// <returns>System.Data.DataTable containing the provided DataColumn.</returns>
        public static DataTable WithColumn(this DataTable table, DataColumn column)
        {
            table.Columns.Add(column);
            return table;
        }
    }
}
