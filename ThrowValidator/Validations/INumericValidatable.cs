using System;

namespace ThrowValidator.Validations
{
    /// <summary>
    /// Define methods to validate numeric structures.
    /// </summary>
    /// <typeparam name="T">Numeric struct.</typeparam>
    public interface INumericValidatable<T>
    {
        /// <summary>
        /// Triggers when the given <paramref name="condition"/> evaluated to be true.
        /// </summary>
        /// <param name="condition">Boolean predicate condition.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> When(Func<bool> condition, string message = null);

        /// <summary>
        /// Triggers when the value is null.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNull(string message = null);

        /// <summary>
        /// Triggers when the value is equal to zero.
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenZero(string message = null);

        /// <summary>
        /// Triggers when the value is greater than zero (positive).
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenPositive(string message = null);

        /// <summary>
        /// Triggers when the value is less than zero (negative).
        /// </summary>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNegative(string message = null);

        /// <summary>
        /// Triggers when the value is less than the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenLessThan(T value, string message = null);

        /// <summary>
        /// Triggers when the value is less than or equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenLessThanOrEqualTo(T value, string message = null);

        /// <summary>
        /// Triggers when the value is greater than the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenGreaterThan(T value, string message = null);

        /// <summary>
        /// Triggers when the value is greater than or equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenGreaterThanOrEqualTo(T value, string message = null);

        /// <summary>
        /// Triggers when the value is equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenEqualTo(T value, string message = null);

        /// <summary>
        /// Triggers when the value is not equal to the given <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value of type T.</param>
        /// <param name="message">Optional message to be shown in the exception when the validation triggered.</param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenNotEqualTo(T value, string message = null);

        /// <summary>
        /// Triggers when the value is within the given range between <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Left bounday value of Type T.</param>
        /// <param name="right">Right bounday value of Type T.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenInRange(T left, T right, Boundary boundary = Boundary.Inclusive, string message = null);

        /// <summary>
        /// Triggers when the value is out of given range of <paramref name="left"/> and <paramref name="right"/>.
        /// </summary>
        /// <param name="left">Left bounday value of Type T.</param>
        /// <param name="right">Right bounday value of Type T.</param>
        /// <param name="boundary">Boundary value comparison whether Inclusive, Exclusive, LeftOnly or RightOnly.</param>
        /// <param name="message"></param>
        /// <returns>Returns <see cref="INumericValidatable{T}"/> with numeric validator.</returns>
        public INumericValidatable<T> WhenOutOfRange(T left, T right, Boundary boundary = Boundary.Exclusive, string message = null);
    }
}
