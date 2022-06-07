using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    public class TypeValidator : ValidationBase, ITypeValidatable
    {
        internal Type type;

        public TypeValidator(Type type)
        {
            this.type = type;
        }

        public TypeValidator(Type type, string message) : this(type)
        {
            _message = message;
        }

        public TypeValidator(Type type, Exception exception) : this(type)
        {
            this.exception = exception;
        }

        public TypeValidator(Type type, Action action) : this(type)
        {
            this.action = action;
        }

        public ITypeValidatable When(Func<bool> condition, string message = null)
        {
            if (condition.Invoke())
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.CONDITION : _message);
                throw exception is not null ? exception : new ConditionNotMeetException(_message);
            }
            return this;
        }

        public ITypeValidatable WhenEqualTo(Type type, string message = null)
        {
            if (this.type == type)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.TYPE_EQUALS, type.FullName) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public ITypeValidatable WhenNotEqualTo(Type type, string message = null)
        {
            if (this.type != type)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.TYPE_NOT_EQUALS, type.FullName) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        public ITypeValidatable WhenNull(string message = null)
        {
            if (type is null)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.TYPE_NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
