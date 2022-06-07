using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class DateTimeValidator : ValidationBase, IDateTimeValidatable
    {
        internal DateTime? dateTime;

        public DateTimeValidator(DateTime? dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTimeValidator(DateTime? dateTime, string message) : this(dateTime)
        {
            _message = message;
        }

        public DateTimeValidator(DateTime? dateTime, Exception exception) : this(dateTime)
        {
            this.exception = exception;
        }

        public DateTimeValidator(DateTime? dateTime, Action action) : this(dateTime)
        {
            this.action = action;
        }
        
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
