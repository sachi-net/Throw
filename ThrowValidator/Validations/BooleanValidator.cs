using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for Boolean (<see cref="bool"/>) values and expressions.
    /// </summary>
    public class BooleanValidator : ValidationBase, IBooleanValidatable
    {
        internal bool? value;

        /// <summary>
        /// Initialize <see cref="BooleanValidator"/> instance with <see cref="bool"/> value to perform validations.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        public BooleanValidator(bool? value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initialize <see cref="BooleanValidator"/> instance with <see cref="bool"/> value to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public BooleanValidator(bool? value, string message) : this(value)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="BooleanValidator"/> instance with <see cref="bool"/> value to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public BooleanValidator(bool? value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="BooleanValidator"/> instance with <see cref="bool"/> value and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="value">Value to be compared.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public BooleanValidator(bool? value, Action action) : this(value)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
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

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is false.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
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

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is null.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
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

        /// <summary>
        /// Triggers when the given <see cref="bool"/> (nullable) expression or value is true.
        /// </summary>
        /// <param name="message">optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IBooleanValidatable"/> with boolean validator.</returns>
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
