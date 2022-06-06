using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class BooleanValidator : ValidationBase, IBooleanValidatable
    {
        internal bool? value;

        public BooleanValidator(bool? value)
        {
            this.value = value;
        }

        public BooleanValidator(bool? value, string message) : this(value)
        {
            _message = message;
        }

        public BooleanValidator(bool? value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        public BooleanValidator(bool? value, Action action) : this(value)
        {
            this.action = action;
        }

        public IBooleanValidatable When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IBooleanValidatable WhenFalse(string message = null)
        {
            if (value is false)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.FALSE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public IBooleanValidatable WhenNull(string message = null)
        {
            if (value is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public IBooleanValidatable WhenTrue(string message = null)
        {
            if (value is true)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.TRUE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
