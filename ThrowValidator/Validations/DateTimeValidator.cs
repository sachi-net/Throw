using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for <see cref="DateTime"/> struct.
    /// </summary>
    public class DateTimeValidator : ValidationBase, IDateTimeValidatable
    {
        internal DateTime? dateTime;

        /// <summary>
        /// Initialize <see cref="DateTimeValidator"/> instance with <see cref="DateTime"/> value to perform validations.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value to be compared.</param>
        public DateTimeValidator(DateTime? dateTime)
        {
            this.dateTime = dateTime;
        }

        /// <summary>
        /// Initialize <see cref="DateTimeValidator"/> instance with <see cref="DateTime"/> value to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value to be compared.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public DateTimeValidator(DateTime? dateTime, string message) : this(dateTime)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="DateTimeValidator"/> instance with <see cref="DateTime"/> value to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value to be compared.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public DateTimeValidator(DateTime? dateTime, Exception exception) : this(dateTime)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="DateTimeValidator"/> instance with <see cref="DateTime"/> value and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="dateTime"><see cref="DateTime"/> value to be compared.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public DateTimeValidator(DateTime? dateTime, Action action) : this(dateTime)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
        public IDateTimeValidatable When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenEqualTo(DateTime? dateTime, string message = null)
        {
            if (this.dateTime == dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.EQUALS, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is greater than the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenGreaterThan(DateTime? dateTime, string message = null)
        {
            if (this.dateTime > dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is greater than or equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenGreaterThanOrEqualTo(DateTime? dateTime, string message = null)
        {
            if (this.dateTime >= dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER_EQ, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is within the given range between <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Date-Time left boundary.</param>
        /// <param name="right">Date-Time right boundary.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="RangeNotMatchException">Throws default exception.</exception>
        public IDateTimeValidatable WhenInRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Inclusive, string message = null)
        {
            bool isInRange = false;

            if (left > right)
            {
                var temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isInRange = dateTime >= left && dateTime <= right;
                    break;
                case Boundary.Exclusive:
                    isInRange = dateTime > left && dateTime < right;
                    break;
                case Boundary.LeftOnly:
                    isInRange = dateTime >= left && dateTime < right;
                    break;
                case Boundary.RightOnly:
                    isInRange = dateTime > left && dateTime <= right;
                    break;
            }
            if (isInRange)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.IN_RANGE, $"({left}, {right})", boundary) : _message);
                throw exception is not null ? exception : new RangeNotMatchException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is less than the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenLessThan(DateTime? dateTime, string message = null)
        {
            if (this.dateTime < dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is less than or equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenLessThanOrEqualTo(DateTime? dateTime, string message = null)
        {
            if (this.dateTime <= dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER_EQ, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is not equal to the given <paramref name="dateTime"/>.
        /// </summary>
        /// <param name="dateTime">Date-time value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenNotEqualTo(DateTime? dateTime, string message = null)
        {
            if (this.dateTime != dateTime)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.NOT_EQUALS, dateTime) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> (nullable) value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
        public IDateTimeValidatable WhenNull(string message = null)
        {
            if (dateTime is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the <see cref="DateTime"/> value is out of the given range of <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Date-Time left boundary.</param>
        /// <param name="right">Date-Time right boundary.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IDateTimeValidatable"/> with date-time validator.</returns>
        /// <exception cref="RangeNotMatchException">Throws default exception.</exception>
        public IDateTimeValidatable WhenOutOfRange(DateTime? left, DateTime? right, Boundary boundary = Boundary.Exclusive, string message = null)
        {
            bool isOutOfRange = false;

            if (left > right)
            {
                var temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isOutOfRange = dateTime <= left || dateTime >= right;
                    break;
                case Boundary.Exclusive:
                    isOutOfRange = dateTime < left || dateTime > right;
                    break;
                case Boundary.LeftOnly:
                    isOutOfRange = dateTime <= left || dateTime > right;
                    break;
                case Boundary.RightOnly:
                    isOutOfRange = dateTime < left || dateTime >= right;
                    break;
            }
            if (isOutOfRange)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.OUT_OF_RANGE, $"({left}, {right})", boundary) : _message);
                throw exception is not null ? exception : new RangeNotMatchException(_message);
            }
            return this;
        }
    }
}
