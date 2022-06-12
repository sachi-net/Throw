using System;

namespace ThrowValidator.Exceptions
{
    /// <summary>
    /// Exception when the value does not fall into the given range.
    /// </summary>
    public class RangeNotMatchException : Exception
    {
        /// <summary>
        /// Initialize an instance of <see cref="RangeNotMatchException"/>.
        /// </summary>
        public RangeNotMatchException()
        {

        }

        /// <summary>
        /// Initialize an instance of <see cref="RangeNotMatchException"/> with specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        public RangeNotMatchException(string message) : base(message)
        {

        }

        /// <summary>
        /// Initialize an instance of <see cref="RangeNotMatchException"/> with specified <paramref name="message"/> and <paramref name="inner"/> exception that cause this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference.</param>
        public RangeNotMatchException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
