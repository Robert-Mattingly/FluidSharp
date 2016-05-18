using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System.Data.SqlClient
{
    /// <summary>
    /// A collection of methods to ease interactions with SqlParameter objects.
    /// </summary>
    public static class SqlParameterExtensions
    {
        /// <summary>
        /// Sets the value of the SqlParameter to the passed value.
        /// </summary>
        /// <param name="param">The SqlParameter whose value will be set.</param>
        /// <param name="value">The value to set.</param>
        /// <returns>The SqlParameter with the updated value.</returns>
        public static SqlParameter WithValue(this SqlParameter param, object value)
        {
            param.Value = value;
            return param;
        }
    }
}
