using System;

namespace ThrowValidator.Exceptions
{
    /// <summary>
    /// Exception when the conditinal predicate does not meet.
    /// </summary>
    public class ConditionNotMeetException : Exception
    {
        /// <summary>
        /// Initialize an instance of <see cref="ConditionNotMeetException"/>.
        /// </summary>
        public ConditionNotMeetException()
        {

        }

        /// <summary>
        /// Initialize an instance of <see cref="ConditionNotMeetException"/> with specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        public ConditionNotMeetException(string message) : base(message)
        {

        }

        /// <summary>
        /// Initialize an instance of <see cref="ConditionNotMeetException"/> with specified <paramref name="message"/> and <paramref name="inner"/> exception that cause this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference.</param>
        public ConditionNotMeetException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
