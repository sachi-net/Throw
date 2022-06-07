using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class CustomValidator<T> : ValidationBase, ICustomTypeValidatable<T>
    {
        internal T value;

        public CustomValidator(T value)
        {
            this.value = value;
        }

        public CustomValidator(T value, string message) : this(value)
        {
            _message = message;
        }

        public CustomValidator(T value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        public CustomValidator(T value, Action action) : this(value)
        {
            this.action = action;
        }

        public ICustomTypeValidatable<T> When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public ICustomTypeValidatable<T> When(Func<T, bool> predicate, string message = null)
        {
            if (predicate.Invoke(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PREDICATE_MEET : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public ICustomTypeValidatable<T> WhenNot(Func<T, bool> predicate, string message = null)
        {
            if (!predicate.Invoke(value))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.PREDICATE_NOT_MEET : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public ICustomTypeValidatable<T> WhenNull(string message = null)
        {
            if (value is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
