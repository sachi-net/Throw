using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for <see cref="Type"/> constructs.
    /// </summary>
    public class TypeValidator : ValidationBase, ITypeValidatable
    {
        internal Type type;

        /// <summary>
        /// Initialize <see cref="TypeValidator"/> instance with <see cref="Type"/> to perform validations.
        /// </summary>
        /// <param name="type">Type construct.</param>
        public TypeValidator(Type type)
        {
            this.type = type;
        }

        /// <summary>
        /// Initialize <see cref="TypeValidator"/> instance with <see cref="Type"/> to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="type">Type construct.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public TypeValidator(Type type, string message) : this(type)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="TypeValidator"/> instance with <see cref="Type"/> to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="type">Type construct.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public TypeValidator(Type type, Exception exception) : this(type)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="TypeValidator"/> instance with <see cref="Type"/> and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="type">Type construct.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public TypeValidator(Type type, Action action) : this(type)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
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

        /// <summary>
        /// Triggers when the <see cref="Type"/> is equal to the given <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Type to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
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

        /// <summary>
        /// Triggers when the <see cref="Type"/> is not equal to the given <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Type to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
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

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ITypeValidatable"/> with type validator.</returns>
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
