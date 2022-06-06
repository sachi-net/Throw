using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class EnumValidator : ValidationBase, IEnumValidatable
    {
        internal Enum @enum;

        public EnumValidator(Enum @enum)
        {
            this.@enum = @enum;
        }

        public EnumValidator(Enum @enum, string message) : this(@enum)
        {
            _message = message;
        }

        public EnumValidator(Enum @enum, Exception exception) : this(@enum)
        {
            this.exception = exception;
        }

        public EnumValidator(Enum @enum, Action action) : this(@enum)
        {
            this.action = action;
        }

        public IEnumValidatable When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public IEnumValidatable WhenEqualTo(Enum @enum, string message = null)
        {
            if (this.@enum.GetHashCode() == @enum.GetHashCode())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.EQUALS, @enum) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public IEnumValidatable WhenNull(string message = null)
        {
            if (@enum is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public IEnumValidatable WhenOutOfRange(int enumIndex, string message = null)
        {
            if (!Enum.IsDefined(@enum.GetType(), @enum))
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.ENUM_OUT_OF_RANGE, @enum, @enum.GetType()) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
