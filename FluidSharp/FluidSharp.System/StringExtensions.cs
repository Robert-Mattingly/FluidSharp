using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System
{
    /// <summary>
    /// A collection of methods to ease interactions with String objects.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the part of the string after the provided number of characters.
        /// </summary>
        /// <param name="value">The string from which the partial string is taken.</param>
        /// <param name="charsToSkip">The number of leading characters to remove.</param>
        /// <returns></returns>
        public static string After(this string value, int charsToSkip)
            => charsToSkip.IsBetweenInclusive(1, value.Length) 
                ? value.Substring(charsToSkip)
                : charsToSkip == 0
                ? value
                : String.Empty;
    }
}
