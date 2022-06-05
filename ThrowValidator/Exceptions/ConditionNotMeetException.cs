using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
