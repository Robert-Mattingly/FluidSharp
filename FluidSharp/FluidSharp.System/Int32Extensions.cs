using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidSharp.System
{
    /// <summary>
    /// A collection of methods to ease interactions with Int32 objects.
    /// </summary>
    public static class Int32Extensions
    {
        /// <summary>
        /// Determines if an Int32 value is within the exclusive boundaries of a range.
        /// </summary>
        /// <param name="value">The Int32 to inspect.</param>
        /// <param name="lowerBoundary">The lower boundary of the range.</param>
        /// <param name="upperBoundary">The upper boundary of the range.</param>
        /// <returns>System.Boolean, true if value is within the exclusive range; otherwise false.</returns>
        public static bool IsBetween(this int value, int lowerBoundary, int upperBoundary)
            => value > lowerBoundary && value < upperBoundary;

        /// <summary>
        /// Determines if an Int32 value is within the inclusive boundaries of a range.
        /// </summary>
        /// <param name="value">The Int32 to inspect.</param>
        /// <param name="lowerBoundary">The lower boundary of the range.</param>
        /// <param name="upperBoundary">The upper boundary of the range.</param>
        /// <returns>System.Boolean, true if value is within the inclusive range; otherwise false.</returns>
        public static bool IsBetweenInclusive(this int value, int lowerBoundary, int upperBoundary)
            => value >= lowerBoundary && value <= upperBoundary;
    }
}
