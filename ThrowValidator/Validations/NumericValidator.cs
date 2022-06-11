using System;
using ThrowValidator.Exceptions;
using ThrowValidator.MessageTemplates;

namespace ThrowValidator.Validations
{
    /// <summary>
    ///  Define validations for numeric structs.
    /// </summary>
    /// <typeparam name="T">Numeric struct.</typeparam>
    public class NumericValidator<T> : ValidationBase, INumericValidatable<T> where T : IComparable<T>
    {
        internal T value;

        /// <summary>
        /// Initialize <see cref="NumericValidator{T}"/> instance with value of type T to perform validations.
        /// </summary>
        /// <param name="value">Numeric value of type T.</param>
        public NumericValidator(T value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initialize <see cref="NumericValidator{T}"/> instance with value of type T to perform validations with custom <paramref name="message"/>.
        /// </summary>
        /// <param name="value">Numeric value of type T.</param>
        /// <param name="message">Custom message in the default exception.</param>
        public NumericValidator(T value, string message) : this(value)
        {
            _message = message;
        }

        /// <summary>
        /// Initialize <see cref="NumericValidator{T}"/> instance with value of type T to perform validations with custom <paramref name="exception"/>.
        /// </summary>
        /// <param name="value">Numeric value of type T.</param>
        /// <param name="exception">Any exception derived from <see cref="Exception"/>.</param>
        public NumericValidator(T value, Exception exception) : this(value)
        {
            this.exception = exception;
        }

        /// <summary>
        /// Initialize <see cref="NumericValidator{T}"/> instance with value of type T and <paramref name="action"/> to invoke when triggering validations.
        /// </summary>
        /// <param name="value">Numeric value of type T.</param>
        /// <param name="action">Custom action of type <see cref="Action"/> with no arguments.</param>
        public NumericValidator(T value, Action action) : this(value)
        {
            this.action = action;
        }

        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> When(Func<bool> condition, string message = null)
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
        /// Triggers when the value is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenEqualTo(T value, string message = null)
        {
            if (this.value.CompareTo(value) is 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is greater than the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenGreaterThan(T value, string message = null)
        {
            if (this.value.CompareTo(value) > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is greater than or equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenGreaterThanOrEqualTo(T value, string message = null)
        {
            if (this.value.CompareTo(value) >= 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.GREATER_EQ, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is within the given range between <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Left bounday value of Type T.</param>
        /// <param name="right">Right bounday value of Type T.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenInRange(T left, T right, Boundary boundary = Boundary.Inclusive, string message = null)
        {
            bool isInRange = false;

            if (left.CompareTo(right) > 0)
            {
                T temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isInRange = value.CompareTo(left) >= 0 && value.CompareTo(right) <= 0;
                    break;
                case Boundary.Exclusive:
                    isInRange = value.CompareTo(left) > 0 && value.CompareTo(right) < 0;
                    break;
                case Boundary.LeftOnly:
                    isInRange = value.CompareTo(left) >= 0 && value.CompareTo(right) < 0;
                    break;
                case Boundary.RightOnly:
                    isInRange = value.CompareTo(left) > 0 && value.CompareTo(right) <= 0;
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
        /// Triggers when the value is less than the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenLessThan(T value, string message = null)
        {
            if (this.value.CompareTo(value) < 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is less than or equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenLessThanOrEqualTo(T value, string message = null)
        {
            if (this.value.CompareTo(value) <= 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.LESSER_EQ, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is less than zero (negative).
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNegative(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (this.value.CompareTo(value) < 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.NEGATIVE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNotEqualTo(T value, string message = null)
        {
            if (this.value.CompareTo(value) is not 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? string.Format(Message.NOT_EQUALS, value) : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNull(string message = null)
        {
            if (value is null)
            {
                action?.Invoke();
                _message =  message ?? (_message is null ? Message.NULL : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is out of given range of <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Left bounday value of Type T.</param>
        /// <param name="right">Right bounday value of Type T.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenOutOfRange(T left, T right, Boundary boundary = Boundary.Exclusive, string message = null)
        {
            bool isOutOfRange = false;

            if (left.CompareTo(right) > 0)
            {
                T temp = left;
                left = right;
                right = temp;
            }

            switch (boundary)
            {
                case Boundary.Inclusive:
                    isOutOfRange = value.CompareTo(left) <= 0 || value.CompareTo(right) >= 0;
                    break;
                case Boundary.Exclusive:
                    isOutOfRange = value.CompareTo(left) < 0 || value.CompareTo(right) > 0;
                    break;
                case Boundary.LeftOnly:
                    isOutOfRange = value.CompareTo(left) <= 0 || value.CompareTo(right) > 0;
                    break;
                case Boundary.RightOnly:
                    isOutOfRange = value.CompareTo(left) < 0 || value.CompareTo(right) >= 0;
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

        /// <summary>
        /// Triggers when the value is greater than zero (positive).
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenPositive(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (this.value.CompareTo(value) > 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.POSITIVE : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }

        /// <summary>
        /// Triggers when the value is equal to zero.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenZero(string message = null)
        {
            T value = (T)Convert.ChangeType(0, typeof(T));
            if (this.value.CompareTo(value) is 0)
            {
                action?.Invoke();
                _message = message ?? (_message is null ? Message.ZERO : _message);
                throw exception is not null ? exception : new ArgumentException(_message);
            }
            return this;
        }
    }
}
