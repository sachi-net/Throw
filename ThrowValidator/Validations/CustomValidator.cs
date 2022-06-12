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
    /// Define validations in-built or custom classes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomValidator<T> : ValidationBase, ICustomTypeValidatable<T>
    {
        internal T value;

        /// <summary>
        /// Initialize <see cref="CustomValidator{T}"/> instance with T object to perform validations.
        /// </summary>
        /// <param name="value">Object to be compared.</param>
        public CustomValidator(T value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initialize <see cref="CustomValidator{T}"/> instance with T object to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="value">Object to be compared.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public CustomValidator(T value, string message) : this(value)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="CustomValidator{T}"/> instance with T object to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="value">Object to be compared.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public CustomValidator(T value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="CustomValidator{T}"/> instance with T object and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="value">Object to be compared.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public CustomValidator(T value, Action action) : this(value)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
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

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be true against this object.
        /// </summary>
        /// <param name="predicate">Boolean predicate condition of this object.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
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

        /// <summary>
        /// Triggers when the given <paramref name="predicate"/> evaluated to be false against this object.
        /// </summary>
        /// <param name="predicate">Boolean predicate condition of this object.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        /// <exception cref="ConditionNotMeetException">Throws default exception.</exception>
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

        /// <summary>
        /// Triggers when the object is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="ICustomTypeValidatable{T}"/> with custom-type validator.</returns>
        /// <exception cref="ArgumentException">Throws default exception.</exception>
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
