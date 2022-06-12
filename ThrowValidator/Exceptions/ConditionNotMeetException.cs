using System;

namespace ThrowValidator.Exceptions
{
    public class ConditionNotMeetException : Exception
    {
        public ConditionNotMeetException()
        {

        }

        public ConditionNotMeetException(string message) : base(message)
        {

        }

        public ConditionNotMeetException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
