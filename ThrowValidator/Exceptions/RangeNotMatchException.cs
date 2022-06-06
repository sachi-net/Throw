using System;

namespace ThrowValidator.Exceptions
{
    internal class RangeNotMatchException : Exception
    {
        public RangeNotMatchException()
        {

        }

        public RangeNotMatchException(string message) : base(message)
        {

        }

        public RangeNotMatchException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
