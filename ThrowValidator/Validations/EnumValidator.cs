using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define validations for enumerators (<see cref="Enum"/>).
    /// </summary>
    public class EnumValidator : ValidationBase, IEnumValidatable
    {
        internal Enum @enum;

        /// <summary>
        /// Initialize <see cref="EnumValidator"/> instance with <see cref="Enum"/> value to perform validations.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> value to be compared.</param>
        public EnumValidator(Enum @enum)
        {
            this.@enum = @enum;
        }

        /// <summary>
        /// Initialize <see cref="EnumValidator"/> instance with <see cref="Enum"/> value to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> value to be compared.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public EnumValidator(Enum @enum, string message) : this(@enum)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="EnumValidator"/> instance with <see cref="Enum"/> value to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> value to be compared.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public EnumValidator(Enum @enum, Exception exception) : this(@enum)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="EnumValidator"/> instance with <see cref="Enum"/> value and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> value to be compared.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public EnumValidator(Enum @enum, Action action) : this(@enum)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
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

        /// <summary>
        /// Triggers when the <see cref="Enum"/> is equal to the given <paramref name="enum"/> value.
        /// </summary>
        /// <param name="enum">Enum value to be compared.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
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

        /// <summary>
        /// Triggers when the <see cref="Enum"/> value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
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

        /// <summary>
        /// Triggers when the given <paramref name="enumIndex"/> is not define in the <see cref="Enum"/>.
        /// </summary>
        /// <param name="enumIndex">Enum index to be evaluated.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="IEnumValidatable"/> with enum validator.</returns>
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
